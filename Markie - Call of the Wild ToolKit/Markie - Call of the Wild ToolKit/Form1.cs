
namespace Markie___Call_of_the_Wild_ToolKit
{
    using Swed64;
    using System.Threading;


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread check = new Thread(FeatuesCheck);
            check.Start();
        }
        private void FeatuesCheck() 
        {
            Swed memory = new Swed("theHunterCotW_F");
            IntPtr moduleBase = memory.GetModuleBase("theHunterCotW_F.exe");

            IntPtr moneyAdress = memory.ReadPointer(moduleBase, 0x023A5578) + 0x388;
            IntPtr skillAdress = memory.ReadPointer(moduleBase, 0x023A5578) + 0x2FC;
            IntPtr perkAdress = memory.ReadPointer(moduleBase, 0x023A5578) + 0x300;
            IntPtr xpAdress = memory.ReadPointer(moduleBase, 0x023A5578) + 0x2F8;
            


            while (true)
            {  
                if (InfMoney.Checked)
                {
                    memory.WriteInt(moneyAdress, 100000);
                }

                if (InfSkill.Checked)
                {
                    memory.WriteInt(skillAdress, 100);
                }

                if (InfPerk.Checked)
                {
                    memory.WriteInt(perkAdress, 100);
                }

                if (InfXp.Checked)
                {
                    int xpint = Convert.ToInt32(xptext.Text);
                    memory.WriteInt(xpAdress, xpint);
                }
                Thread.Sleep(1000);
            }
        }
    }
}


