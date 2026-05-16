using InventorySystem.Items.Usables.Scp330;
using LabApi.Events.Arguments.PlayerEvents;
using LabApi.Events.CustomHandlers;

namespace DisplayTheCandyTaken
{
    public class EventsHandler : CustomEventsHandler
    {
        public override void OnPlayerInteractedScp330(PlayerInteractedScp330EventArgs ev)
        {
            if (ev?.Player == null)
            {
                return;
            }
            
            if (ev.CandyType == CandyKindID.Black) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#000000>Noir</color></size>", Plugin.Instance.Config.HintDuration); 
            }

            if (ev.CandyType == CandyKindID.White)
            {
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#ffffff>Blanc</color></size>", Plugin.Instance.Config.HintDuration);
            }
            
            if (ev.CandyType == CandyKindID.Red)
            {
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#ff0000>Rouge</color></size>", Plugin.Instance.Config.HintDuration);
            }
            
            if (ev.CandyType == CandyKindID.Blue) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#0090FF>Bleu</color></size>", Plugin.Instance.Config.HintDuration); 
            }
            
            if (ev.CandyType == CandyKindID.Black) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#000000>Noir</color></size>", Plugin.Instance.Config.HintDuration); 
            }
            
            if (ev.CandyType == CandyKindID.Gray) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#a0a0a0>Gris</color></size>", Plugin.Instance.Config.HintDuration); 
            }
            
            if (ev.CandyType == CandyKindID.Green) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#18A811>Vert</color></size>", Plugin.Instance.Config.HintDuration); 
            }
            
            if (ev.CandyType == CandyKindID.Brown) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#85461D>Marron</color></size>", Plugin.Instance.Config.HintDuration); 
            }
            
            if (ev.CandyType == CandyKindID.Orange) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#FF6600>Orange</color></size>", Plugin.Instance.Config.HintDuration); 
            }
            
            if (ev.CandyType == CandyKindID.Evil) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#9E0642>démoniaque</color></size>", Plugin.Instance.Config.HintDuration); 
            }
            
            if (ev.CandyType == CandyKindID.Yellow) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#FFFA1C>Jaune</color></size>", Plugin.Instance.Config.HintDuration); 
            }
            
            if (ev.CandyType == CandyKindID.Pink) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#FA41B6>Rose</color></size>", Plugin.Instance.Config.HintDuration); 
            }
            
            if (ev.CandyType == CandyKindID.Rainbow) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#00FF80>M</color><color=#00FFFF>u</color><color=#0080FF>l</color><color=#0000FF>t</color><color=#4000FF>i</color><color=#8000FF>c</color><color=#BF00FF>o</color><color=#FF00FF>l</color><color=#FF00BF>o</color><color=#FF0080>r</color><color=#FF0040>e</color></size>", Plugin.Instance.Config.HintDuration); 
            }
            
            if (ev.CandyType == CandyKindID.Purple) 
            { 
                ev.Player.SendHint(Plugin.Instance.Config.HintMessage + "<size=30><color=#8B12E5>Violet</color></size>", Plugin.Instance.Config.HintDuration); 
            }
        }
    }
}