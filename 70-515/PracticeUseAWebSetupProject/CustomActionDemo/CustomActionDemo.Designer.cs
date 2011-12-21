using System.Configuration;
namespace CustomActionDemo {
    partial class CustomActionDemo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
        }

        #endregion

        

        /// <summary>
        ///  Override bass install class's Install method
        /// </summary>
        /// <param name="stateSaver"></param>
        public override void Install(System.Collections.IDictionary stateSaver) {

            base.Install(stateSaver);



            // Get the web application's virtual directory on target server

            string targetVDir = Context.Parameters["targetvdir"];

            // Get the value that customer inputs in Wizard while installing

            string newConnectionString = Context.Parameters["connectionstringvalue"];



            // Get web.config 

            Configuration config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/" + targetVDir);

            // Retrieve connectioString Section

            ConnectionStringsSection connectionStrings = config.ConnectionStrings;

            // Set Settings with key "UserData"

            connectionStrings.ConnectionStrings["ApplicationServices"].ConnectionString = newConnectionString;

            // Save web.config 

            config.Save();



        }
    }
}