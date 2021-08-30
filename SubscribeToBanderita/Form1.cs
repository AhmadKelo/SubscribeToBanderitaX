using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace SubscribeToBanderita
{
    public partial class frm1 : Form
    {

        InputSimulator sim = new InputSimulator();

        public frm1()
        {
            InitializeComponent();
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            cmb_Browser.SelectedIndex = 0;
            cmb_LikeOrDislike.SelectedIndex = 0;

        }

        private void btn_Subscribe_Click(object sender, EventArgs e)
        {
                    
            OpenBrowser(cmb_Browser.Text);

            Subscribe();

            LikeOrDislike(cmb_LikeOrDislike.SelectedIndex);
            
        }


        public void PressRepeat(int times, int sleepTime, VirtualKeyCode virtualKeyCode)
        {
            for (int i = 1; i <= times; i++)
            {
                sim.Keyboard.Sleep(sleepTime);
                sim.Keyboard.KeyPress(virtualKeyCode);
            }
        }

        public void OpenBrowser(string browserName)
        {
            SendKeys.Send("^{ESC}"); //Open Windows Search

            //Serach Firefox
            sim.Keyboard.Sleep(200);
            sim.Keyboard.TextEntry(browserName);
            sim.Keyboard.Sleep(200);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }
        public void Subscribe()
        {
            //Search For Bander's Channel
            sim.Keyboard.Sleep(1500);
            sim.Keyboard.TextEntry("https://www.youtube.com/c/BanderitaX/videos");
            sim.Keyboard.Sleep(200);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            //Go to Subscribe Button
            sim.Keyboard.Sleep(3500);
            PressRepeat(3, 200, VirtualKeyCode.TAB);

            //Skip Navigation
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            sim.Keyboard.Sleep(200);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);

            //Subscribe
            sim.Keyboard.Sleep(400);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            //Go to Notifications
            sim.Keyboard.Sleep(200);
            sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
            //Open Notifictaion Chooser
            sim.Keyboard.Sleep(400);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            //Open All Notifications
            sim.Keyboard.Sleep(400);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }
        public void LikeOrDislike(int isLike)
        {
            //Go to Last Video
            PressRepeat(10, 200, VirtualKeyCode.TAB);

            //Open The Video
            sim.Keyboard.Sleep(200);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            //Go to Like Button
            sim.Keyboard.Sleep(3000);
            PressRepeat(11 + isLike, 200, VirtualKeyCode.TAB);

            //Like the Video
            sim.Keyboard.Sleep(200);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

    }

}
