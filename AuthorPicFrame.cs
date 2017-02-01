namespace Oxide.Plugins
{
    [Info("AuthorPicFrame", "Acidix", "0.1.1")]
    [Description("Log persons who are painting on a picture frame")]

    public class AuthorPicFrame : RustPlugin
    {
        public static AuthorPicFrame thisPlugin;

		void Loaded(){
			Puts(Core.Interface.Oxide.LogDirectory);
		}
        void OnSignUpdate(Signage sign, BasePlayer player)
        {
            string namePathFileLog = "\\AuthorPicFrame_" + System.DateTime.Now.Year.ToString() + "-" + System.DateTime.Now.Month.ToString() + "-" + System.DateTime.Now.Day.ToString() + ".txt"; // pluginname_yyyy - MM - dd.txt;
            string currentHour = System.DateTime.Now.Hour.ToString() + "h" + System.DateTime.Now.Minute.ToString();
            string currentTab = sign.textureID.ToString();
            string nameDateDrawn = currentHour + " Author:" + player.displayName + " Path picframe writed:/storage/" + currentTab + "/0/ " + " SteamID Player:" + player.userID;
            ConVar.Server.Log(namePathFileLog, nameDateDrawn + System.Environment.NewLine);
        }
    }
}