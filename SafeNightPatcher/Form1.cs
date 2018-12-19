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
            if (Configuration.currentConfig.AutoPoke == true)
            {
                checkBox1.Checked = true;
                btnMusicPoke.Enabled = false;
                buttonPoke.Enabled = false;
            }
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
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            buttonDisconn.Enabled = true;
            buttonConnect.Enabled = false;
            if (checkBox1.Checked)
                mapCheckerTimer.Start();

            Configuration.currentConfig.lastIp = IPBox.Text;
            Configuration.currentConfig.AutoPoke = checkBox1.Checked;
            Configuration.Save();
        }

        private void buttonDisconn_Click(object sender, EventArgs e)
        {
            Gecko.Disconnect();
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            buttonDisconn.Enabled = false;
            buttonConnect.Enabled = true;
            ObjectTimer.Stop();
            mapCheckerTimer.Stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMusicPoke_Click(object sender, EventArgs e)
        {

        }

        private void buttonPoke_Click(object sender, EventArgs e)
        {
            pokeMaps();
            MessageBox.Show("Maps poked!", "Safe NightPatcher", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void CheckedChanged(object sender, EventArgs e)
        {

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
                    hammerheadBridgeOrBox.Checked = false;
                    hammerheadBridgeOrBox.Checked = false;
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

        private void hammerheadBridgeOrBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hammerheadBridgeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                DialogResult dr = MessageBox.Show("This map will require the automatic poking feature to be turned on. Do you want to turn this feature on? (Note: this feature cannot be turned off as long as this map is selected)", "Notice", MessageBoxButtons.YesNo);
                if (dr == DialogResult.OK)
                {
                    checkBox1.Checked = true;
                    checkBox1.Enabled = false;
                    if (hammerheadBridgeOrBox.Checked)
                        hammerheadBridgeOrBox.Checked = false;
                    if (hammerheadBridgeBox.Checked)
                    {
                        DialogResult dialogResult = MessageBox.Show("This version of Hammerhead Bridge has yet to be througly tested for desync issues. We cannot guarantee this map is fully safe yet.", "WARNING", MessageBoxButtons.OK);
                        ObjectTimer.Start();
                    }
                    else
                    {
                        ObjectTimer.Stop();
                        checkBox1.Enabled = false;
                    }
                    if (checkBox1.Checked)
                        pokeMaps();
                }
            }
            else
            {
                checkBox1.Enabled = false;
                if (hammerheadBridgeOrBox.Checked)
                    hammerheadBridgeOrBox.Checked = false;
                if (hammerheadBridgeBox.Checked)
                {
                    DialogResult dialogResult = MessageBox.Show("This version of Hammerhead Bridge has yet to be througly tested for desync issues. We cannot guarantee this map is fully safe yet.", "WARNING", MessageBoxButtons.OK);
                    ObjectTimer.Start();
                }
                else
                {
                    ObjectTimer.Stop();
                    checkBox1.Enabled = true;
                }
                if (checkBox1.Checked)
                    pokeMaps();
            }
        }

        private uint Base = 0x106E118C;

        private void ObjectTimer_Tick(object sender, EventArgs e)
        {
            DeleteObjects();
        }

        private void DeleteObjects()
        {
            bool tmp = false;
            uint MapData = Gecko.peek(Base);
            uint Object = Gecko.peek(MapData + 0x00000038);
            if (Gecko.peek(Object + 0x00000030) == 0x442835A8)
                tmp = true;
            else if (Gecko.peek(Gecko.peek(MapData + 0x00000058) + 0x00000030) == 0x442835A8)
                tmp = true;
            else if (Gecko.peek(Gecko.peek(MapData + 0x0000006c) + 0x00000030) == 0x442835A8)
                tmp = true;
            else if (Gecko.peek(Gecko.peek(MapData + 0x00000060) + 0x00000030) == 0x442835A8)
                tmp = true;
            if (Gecko.peek(0x12B4F15C) == 0x00000001 && Gecko.peek(0x10709294) == 0x4B616973 && tmp == true && hammerheadBridgeBox.Checked)
            {
                MapData = Gecko.peek(Base);
                Object = Gecko.peek(MapData);

                uint Object1;
                uint Object2;
                uint Object3;
                uint Object4;

                if (Gecko.peek(Gecko.peek(MapData + 0x00000038) + 0x00000030) == 0x442835A8)
                {
                    Object1 = Gecko.peek(MapData + 0x00000038);
                    Object2 = Gecko.peek(MapData + 0x0000003c);
                    Object3 = Gecko.peek(MapData + 0x00000040);
                    Object4 = Gecko.peek(MapData + 0x00000044);
                }
                else if (Gecko.peek(Gecko.peek(MapData + 0x00000058) + 0x00000030) == 0x442835A8)
                {
                    Object1 = Gecko.peek(MapData + 0x00000058);
                    Object2 = Gecko.peek(MapData + 0x0000005c);
                    Object3 = Gecko.peek(MapData + 0x00000060);
                    Object4 = Gecko.peek(MapData + 0x00000064);
                }
                else if (Gecko.peek(Gecko.peek(MapData + 0x0000006c) + 0x00000030) == 0x442835A8)
                {
                    Object1 = Gecko.peek(MapData + 0x0000006c);
                    Object2 = Gecko.peek(MapData + 0x00000070);
                    Object3 = Gecko.peek(MapData + 0x00000074);
                    Object4 = Gecko.peek(MapData + 0x00000078);
                }
                else
                {
                    Object1 = Gecko.peek(MapData + 0x00000060);
                    Object2 = Gecko.peek(MapData + 0x00000064);
                    Object3 = Gecko.peek(MapData + 0x00000068);
                    Object4 = Gecko.peek(MapData + 0x0000006c);
                }

                uint Object1_Model = Gecko.peek(Object1 + 0x000001E4);
                uint Object2_Model = Gecko.peek(Object2 + 0x000001E4);
                uint Object3_Model = Gecko.peek(Object3 + 0x000001E4);
                uint Object4_Model = Gecko.peek(Object4 + 0x000001E4);

                System.Threading.Thread.Sleep(100);
                Object1 = Object1 + 0x00000004;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object1 + (i * 0x00000008), 0x00000000);
                Object1 = Object1 + 0x00000010;
                for (uint i = 0; i < 2; i++)
                    Gecko.poke(Object1 + (i * 0x00000004), 0x00000000);

                Object1_Model = Object1_Model + 0x00000054;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object1_Model + (i * 0x00000008), 0x00000000);
                Object1_Model = Object1_Model + 0x00000040;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object1_Model + (i * 0x00000008), 0x00000000);
                Object1_Model = Object1_Model + 0x00000010;
                for (uint i = 0; i < 3; i++)
                    Gecko.poke(Object1_Model + (i * 0x00000004), 0x00000000);

                Object2 = Object2 + 0x00000004;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object2 + (i * 0x00000008), 0x00000000);
                Object2 = Object2 + 0x00000010;
                for (uint i = 0; i < 2; i++)
                    Gecko.poke(Object2 + (i * 0x00000004), 0x00000000);

                Object2_Model = Object2_Model + 0x00000054;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object2_Model + (i * 0x00000008), 0x00000000);
                Object2_Model = Object2_Model + 0x00000040;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object2_Model + (i * 0x00000008), 0x00000000);
                Object2_Model = Object2_Model + 0x00000010;
                for (uint i = 0; i < 3; i++)
                    Gecko.poke(Object2_Model + (i * 0x00000004), 0x00000000);

                Object3 = Object3 + 0x00000004;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object3 + (i * 0x00000008), 0x00000000);
                Object3 = Object3 + 0x00000010;
                for (uint i = 0; i < 2; i++)
                    Gecko.poke(Object3 + (i * 0x00000004), 0x00000000);

                Object3_Model = Object3_Model + 0x00000054;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object3_Model + (i * 0x00000008), 0x00000000);
                Object3_Model = Object3_Model + 0x00000040;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object3_Model + (i * 0x00000008), 0x00000000);
                Object3_Model = Object3_Model + 0x00000010;
                for (uint i = 0; i < 3; i++)
                    Gecko.poke(Object3_Model + (i * 0x00000004), 0x00000000);

                Object4 = Object4 + 0x00000004;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object4 + (i * 0x00000008), 0x00000000);
                Object4 = Object4 + 0x00000010;
                for (uint i = 0; i < 2; i++)
                    Gecko.poke(Object4 + (i * 0x00000004), 0x00000000);

                Object4_Model = Object4_Model + 0x00000054;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object4_Model + (i * 0x00000008), 0x00000000);
                Object4_Model = Object4_Model + 0x00000040;
                for (uint i = 0; i < 5; i++)
                    Gecko.poke(Object4_Model + (i * 0x00000008), 0x00000000);
                Object4_Model = Object4_Model + 0x00000010;
                for (uint i = 0; i < 3; i++)
                    Gecko.poke(Object4_Model + (i * 0x00000004), 0x00000000);
            }
            else
                System.Threading.Thread.Sleep(500);
        }

        private void mapCheckerTimer_Tick(object sender, EventArgs e)
        {
            currentMap();
        }

        private void trackRevert(int Selection)
        {
            if (Selection <= 0)
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
            else if (Selection == 1)
            {
                for (uint i = 0; i < 9; i++)
                    Gecko.poke(0x106E42F8 + (i * 0x00000004), 0x10532008);
            }
            else if (Selection == 2)
            {
                for (uint i = 0; i < 9; i++)
                    Gecko.poke(0x106E42F8 + (i * 0x00000004), 0x10532018);
            }
        }

        private void pokeMaps()
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

            if (hammerheadBridgeBox.Checked || hammerheadBridgeOrBox.Checked)
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

        private void currentMap()
        {
            uint MapCheck = Gecko.peek(0x12D1EECC);

            if (MapCheck == 0x4F666669 && Gecko.peek(0x12B4F8F4) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x4F666669 && Gecko.peek(0x12B4F8F4) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x5570446F && Gecko.peek(0x12B4DFA4) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x5570446F && Gecko.peek(0x12B4DFA4) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x536B6174 && Gecko.peek(0x12B4E22C) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x536B6174 && Gecko.peek(0x12B4E22C) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x5275696E && Gecko.peek(0x12B4E73C) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x5275696E && Gecko.peek(0x12B4E73C) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x4174686C && Gecko.peek(0x12B4E4B4) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x4174686C && Gecko.peek(0x12B4E4B4) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x4A796F68 && Gecko.peek(0x12B4F3E4) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x4A796F68 && Gecko.peek(0x12B4F3E4) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x4B616973 && Gecko.peek(0x12B4F15C) == 0x00000001 && hammerheadBridgeOrBox.Checked)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x4B616973 && Gecko.peek(0x12B4F15C) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x4B616973 && Gecko.peek(0x12B4F15C) == 0x00000001 && hammerheadBridgeBox.Checked)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x4B616973 && Gecko.peek(0x12B4F15C) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x4D617A65 && Gecko.peek(0x12B4EC4C) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x4D617A65 && Gecko.peek(0x12B4EC4C) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x48696167 && Gecko.peek(0x12B4FB7C) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x48696167 && Gecko.peek(0x12B4FB7C) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x54757A75 && Gecko.peek(0x12B4EED4) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x54757A75 && Gecko.peek(0x12B4EED4) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x5069766F && Gecko.peek(0x12B4F66C) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x5069766F && Gecko.peek(0x12B4F66C) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x51756172 && Gecko.peek(0x12B4FE04) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x51756172 && Gecko.peek(0x12B4FE04) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x416D6964 && Gecko.peek(0x12B4E9C4) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x416D6964 && Gecko.peek(0x12B4E9C4) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x53656150 && Gecko.peek(0x12B4DD1C) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x53656150 && Gecko.peek(0x12B4DD1C) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x4372616E && Gecko.peek(0x12B4D80C) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x4372616E && Gecko.peek(0x12B4D80C) == 0x00000000)
                trackRevert(0);

            if (MapCheck == 0x57617265 && Gecko.peek(0x12B4DA94) == 0x00000001)
                trackRevert(cmbMusic.SelectedIndex);
            else if (MapCheck == 0x57617265 && Gecko.peek(0x12B4DA94) == 0x00000000)
                trackRevert(0);
        }
    }
}
