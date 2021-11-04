using System;
using System.Windows.Forms;

namespace SafeNightPatcher
{
    public partial class Form1 : Form
    {

        public TCPGecko Gecko;
        public uint diff;
        public static uint mapCheck;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Configuration.Load();
            IPBox.Text = Configuration.currentConfig.lastIp;
            this.Text += " (" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + ")";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Gecko = new TCPGecko(IPBox.Text, 7331);
            try
            {
                Gecko.Connect();
            }
            catch (ETCPGeckoException)
            {
                MessageBox.Show("Connection to the Gecko client failed!: \n\n" + "\n\nPlease check your network connection/firewall.", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            //offset difference checker
            uint JRAddr = Gecko.peek(0x106E975C) + 0x92D8;
            if (Gecko.peek(JRAddr) == 0x000003F2)
            {
                diff = JRAddr - 0x12CDADA0;
            }
            else
            {
                MessageBox.Show("The program cannot find the Splattershot Jr. in memory.  It's possible the program doesn't support the version of Gecko you are using.  Please make sure Splatoon is running and try again using a supported version of Gecko. ", "Unsupported Gecko version found!", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                Gecko.Disconnect();
                return;
            }

            Gecko.poke(0x10014cfc, 0x00000001);
            System.Threading.Thread.Sleep(100);

            groupBox2.Enabled = true;
            buttonDisconn.Enabled = true;
            buttonConnect.Enabled = false;
            //mapCheckerTimer.Start(); //will be used later

            Configuration.currentConfig.lastIp = IPBox.Text;
            Configuration.Save();
        }

        private void buttonDisconn_Click(object sender, EventArgs e)
        {
            Gecko.Disconnect();
            groupBox2.Enabled = false;
            buttonDisconn.Enabled = false;
            buttonConnect.Enabled = true;
            //mapCheckerTimer.Stop(); //will be used later
        }

        private void buttonPoke_Click(object sender, EventArgs e)
        {
            {
                if (anchovGamesBox.Checked)
                    Gecko.poke(0x12B4F8F4, 0x00000001);
                else
                    Gecko.poke(0x12B4F8F4, 0x00000000);

                if (arowanaMallBox.Checked)
                    Gecko.poke(0x12B4DFA4, 0x00000001);
                else
                    Gecko.poke(0x12B4DFA4, 0x00000000);

                if (blackBellySkateparkBox.Checked)
                    Gecko.poke(0x12B4E22C, 0x00000001);
                else
                    Gecko.poke(0x12B4E22C, 0x00000000);

                if (bluefinDepotBox.Checked)
                    Gecko.poke(0x12B4E73C, 0x00000001);
                else
                    Gecko.poke(0x12B4E73C, 0x00000000);

                if (campTriggerfishBox.Checked)
                    Gecko.poke(0x12B4E4B4, 0x00000001);
                else
                    Gecko.poke(0x12B4E4B4, 0x00000000);

                if (flounderHeightsBox.Checked)
                    Gecko.poke(0x12B4F3E4, 0x00000001);
                else
                    Gecko.poke(0x12B4F3E4, 0x00000000);

                if (hammerheadBridgeBox.Checked)
                    Gecko.poke(0x12B4F15C, 0x00000001);
                else
                    Gecko.poke(0x12B4F15C, 0x00000000);

                if (kelpDomeBox.Checked)
                    Gecko.poke(0x12B4EC4C, 0x00000001);
                else
                    Gecko.poke(0x12B4EC4C, 0x00000000);

                if (mahimahiResortBox.Checked)
                    Gecko.poke(0x12B4FB7C, 0x00000001);
                else
                    Gecko.poke(0x12B4FB7C, 0x00000000);

                if (morayTowersBox.Checked)
                    Gecko.poke(0x12B4EED4, 0x00000001);
                else
                    Gecko.poke(0x12B4EED4, 0x00000000);

                if (museumDalfonsinoBox.Checked)
                    Gecko.poke(0x12B4F66C, 0x00000001);
                else
                    Gecko.poke(0x12B4F66C, 0x00000000);

                if (piranhaPitBox.Checked)
                    Gecko.poke(0x12B4FE04, 0x00000001);
                else
                    Gecko.poke(0x12B4FE04, 0x00000000);

                if (portMackerelBox.Checked)
                    Gecko.poke(0x12B4E9C4, 0x00000001);
                else
                    Gecko.poke(0x12B4E9C4, 0x00000000);

                if (saltsprayRigBox.Checked)
                    Gecko.poke(0x12B4DD1C, 0x00000001);
                else
                    Gecko.poke(0x12B4DD1C, 0x00000000);

                if (urchinUnderpassBox.Checked)
                    Gecko.poke(0x12B4D80C, 0x00000001);
                else
                    Gecko.poke(0x12B4D80C, 0x00000000);

                if (walleyeWarehouseBox.Checked)
                    Gecko.poke(0x12B4DA94, 0x00000001);
                else
                    Gecko.poke(0x12B4DA94, 0x00000000);
            }

            {

            }

            MessageBox.Show("Maps poked!", "Safe NightPatcher", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toggleAll_Click(object sender, EventArgs e)
        {
            {
                if (anchovGamesBox.Checked && arowanaMallBox.Checked && blackBellySkateparkBox.Checked
                        && bluefinDepotBox.Checked && campTriggerfishBox.Checked && flounderHeightsBox.Checked
                            && kelpDomeBox.Checked && mahimahiResortBox.Checked && morayTowersBox.Checked
                                && museumDalfonsinoBox.Checked && piranhaPitBox.Checked && portMackerelBox.Checked
                                    && saltsprayRigBox.Checked && urchinUnderpassBox.Checked && walleyeWarehouseBox.Checked)
                {
                    anchovGamesBox.Checked = false;
                    arowanaMallBox.Checked = false;
                    blackBellySkateparkBox.Checked = false;
                    bluefinDepotBox.Checked = false;
                    campTriggerfishBox.Checked = false;
                    flounderHeightsBox.Checked = false;
                    hammerheadBridgeBox.Checked = false;
                    kelpDomeBox.Checked = false;
                    mahimahiResortBox.Checked = false;
                    morayTowersBox.Checked = false;
                    museumDalfonsinoBox.Checked = false;
                    piranhaPitBox.Checked = false;
                    portMackerelBox.Checked = false;
                    saltsprayRigBox.Checked = false;
                    urchinUnderpassBox.Checked = false;
                    walleyeWarehouseBox.Checked = false;
                }
                else
                {
                    anchovGamesBox.Checked = true;
                    arowanaMallBox.Checked = true;
                    blackBellySkateparkBox.Checked = true;
                    bluefinDepotBox.Checked = true;
                    campTriggerfishBox.Checked = true;
                    flounderHeightsBox.Checked = true;
                    kelpDomeBox.Checked = true;
                    mahimahiResortBox.Checked = true;
                    morayTowersBox.Checked = true;
                    museumDalfonsinoBox.Checked = true;
                    piranhaPitBox.Checked = true;
                    portMackerelBox.Checked = true;
                    saltsprayRigBox.Checked = true;
                    urchinUnderpassBox.Checked = true;
                    walleyeWarehouseBox.Checked = true;
                }
            }
        }

        private void hammerheadBridgeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hammerheadBridgeBox.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Hammerhead Bridge is known to cause serious desync issues.  It is recommended to only use night mode for this map in Private Battle with each player synced up.  Are you sure you want to enable night mode for this map?", "WARNING", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    hammerheadBridgeBox.Checked = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    hammerheadBridgeBox.Checked = false;
                }
            }
        }

        private void vsMusicFix_CheckedChanged(object sender, EventArgs e) //temporary - this will be deleted once a proper method for night detection is complete.
        {
            {
                if (vsMusicFix.Checked == true)

                {
                    for (uint i = 0; i < 9; i++)
                        Gecko.poke(0x106E42F8 + (i * 0x00000004), 0x10532008);
                }
                else if (vsMusicFix.Checked == false)
                {
                    Gecko.poke(0x106E42F8, 0x10531F9C);
                    Gecko.poke(0x106E42FC, 0x10531FA8);
                    Gecko.poke(0x106E4300, 0x10531FB4);
                    Gecko.poke(0x106E4304, 0x10531FC0);
                    Gecko.poke(0x106E4308, 0x10531FCC);
                    Gecko.poke(0x106E430C, 0x10531FD8);
                    Gecko.poke(0x106E4310, 0x10531FE4);
                    Gecko.poke(0x106E4314, 0x10531FF0);
                    Gecko.poke(0x106E4318, 0x10531FFC);
                }
            }
        }

        //The following code is incomplete and does not function properly yet.  Because of this, it's been disabled for now.

        private void currentMap()
        {
                //uint mapCheck = Gecko.peek(0x106E118C);
                //if (mapCheck == 0x1FC59480 && arowanaMallBox.Checked == true || mapCheck == 0x1FCE5288 && museumDalfonsinoBox.Checked == true
                        //|| mapCheck == 0xBD924925 && hammerheadBridgeBox.Checked == true || mapCheck == 0x3F1C18FA && morayTowersBox.Checked == true
                            //|| mapCheck == 0x1FD41704 && urchinUnderpassBox.Checked == true || mapCheck == 0x1CC && portMackerelBox.Checked == true)
                {
                //for (uint i = 0; i < 9; i++)
                    //Gecko.poke(0x106E42F8 + (i * 0x00000004), 0x10532008);
                }
                //else
                {
                        //trackRevert();
                }
        }

        
        private void mapCheckerTimer_Tick(object sender, EventArgs e)
        {
            //currentMap();
        }

        private void trackRevert()
        {
            //Gecko.poke(0x106E42F8, 0x10531F9C);
            //Gecko.poke(0x106E42FC, 0x10531FA8);
            //Gecko.poke(0x106E4300, 0x10531FB4);
            //Gecko.poke(0x106E4304, 0x10531FC0);
            //Gecko.poke(0x106E4308, 0x10531FCC);
            //Gecko.poke(0x106E430C, 0x10531FD8);
            //Gecko.poke(0x106E4310, 0x10531FE4);
            //Gecko.poke(0x106E4314, 0x10531FF0);
            //Gecko.poke(0x106E4318, 0x10531FFC);
        }

    }
}
