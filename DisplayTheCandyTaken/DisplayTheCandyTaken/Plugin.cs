using System;
using LabApi.Events.CustomHandlers;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;
using LabApi.Loader.Features.Plugins.Enums;

namespace DisplayTheCandyTaken
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override string Name => "DisplayTheCandyTaken";
        public override string Description => "Display the candy taken.";
        public override string Author => "Kiore";
        public override Version Version => new Version(1, 0);
        public override Version RequiredApiVersion => new Version(LabApiProperties.CompiledVersion);
        public override LoadPriority Priority => LoadPriority.Low;
        public EventsHandler Events => new EventsHandler();

        public override void Enable()
        {
            Instance = this;
            CustomHandlersManager.RegisterEventsHandler(Events);
        }

        public override void Disable()
        {
            CustomHandlersManager.UnregisterEventsHandler(Events);
        }
    }
}