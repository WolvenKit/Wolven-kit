﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using Catel.Linq;
using CP77.CR2W.Types;
using Newtonsoft.Json;
using Orc.ProjectManagement;
using WolvenKit.Common;
using WolvenKit.Model;

namespace WolvenKit.Controllers
{
    using Services;
    using Bundles;
    using Cache;
    using Common.Services;
    using W3Speech;
    using W3Strings;
    using CP77.CR2W.Archive;

    public class Cp77Controller : GameControllerBase
    {
        private static ArchiveManager archiveManager { get; set; } = new ArchiveManager();

        public ArchiveManager LoadArchiveManager()
        {
            var _settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            var _logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            _logger.LogString("Loading archive Manager ... ", Logtype.Important);
            try
            {
                if (File.Exists(Cp77Controller.GetManagerPath(EManagerType.ArchiveManager)))
                {
                    using (StreamReader file = File.OpenText(Cp77Controller.GetManagerPath(EManagerType.ArchiveManager)))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                        serializer.TypeNameHandling = TypeNameHandling.Auto;
                        archiveManager = (ArchiveManager)serializer.Deserialize(file, typeof(ArchiveManager));
                    }
                }
                else
                {
                    archiveManager = new ArchiveManager();
                    archiveManager.LoadAll(Path.GetDirectoryName(_settings.CP77ExecutablePath));
                    File.WriteAllText(Cp77Controller.GetManagerPath(EManagerType.ArchiveManager), JsonConvert.SerializeObject(archiveManager, Formatting.None, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                    _settings.ManagerVersions[(int)EManagerType.ArchiveManager] = ArchiveManager.SerializationVersion;
                }
            }
            catch (Exception)
            {
                if (File.Exists(GetManagerPath(EManagerType.ArchiveManager)))
                    File.Delete(GetManagerPath(EManagerType.ArchiveManager));
                archiveManager = new ArchiveManager();
                archiveManager.LoadAll(Path.GetDirectoryName(_settings.CP77ExecutablePath));
            }
            _logger.LogString("Finished loading archive manager.", Logtype.Success);
            return archiveManager;
        }

        public override List<IGameArchiveManager> GetArchiveManagersManagers()
        {
            return new()
            {
                archiveManager
            };
        }

        public override List<string> GetAvaliableClasses()
        {
            return CR2WTypeManager.AvailableTypes.ToList();
        }

        public override void HandleStartup()
        {
            List<Func<IGameArchiveManager>> todo = new List<Func<IGameArchiveManager>>()
            {
                LoadArchiveManager
            };
            Parallel.ForEach(todo, _ => Task.Run(_));
        }

        public override Task<bool> PackAndInstallroject()
        {
            var _loggerService = ServiceLocator.Default.ResolveType<ILoggerService>();
            var _projectService = ServiceLocator.Default.ResolveType<IProjectManager>();
            var cp77proj = _projectService.ActiveProject as Cp77Project;
            if (cp77proj == null)
            {
                _loggerService.LogString("Can't pack nor install project (no project/not cyberpunk project)!", Logtype.Error);
                return new Task<bool>(new Func<bool>(() => false));
            }
            _loggerService.LogString("Rebuilding necessary files....", Logtype.Normal);
            CP77.CR2W.ModTools.Recombine(new DirectoryInfo(cp77proj.ModDirectory), true, true, true, true, true, true);
            _loggerService.LogString("Rebuilding done, packing files into archive(s)....", Logtype.Normal);
            CP77.CR2W.ModTools.Pack(new DirectoryInfo(cp77proj.ModDirectory),
                new DirectoryInfo(cp77proj.PackedModDirectory));
            _loggerService.LogString("Packing complete!", Logtype.Important);
            return new Task<bool>(new Func<bool>(() => false));
        }
    }
}
