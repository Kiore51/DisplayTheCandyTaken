using System.ComponentModel;

namespace DisplayTheCandyTaken
{
    public class Config
    {
        public bool Enabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Custom message.")]
        public string HintMessage { get; set; } = "<size=25><color=#727472>Vous avez pris un bonbon</color></size> ";
        public ushort HintDuration { get; set; } = 3;
    }
}