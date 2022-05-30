using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace AutoCauCa
{
    public partial class AutoPlayTogether : Form
    {
        public AutoPlayTogether()
        {
            InitializeComponent();
        }
        //Mem mem = new Mem();

        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_LBUTTONUP = 0x0202;
        

        private string nameproc;
        private bool daco,openProc;
        private int pid,id,pos;
        private bool locbong=false, tangtocdo=false, trolen=false, kichhoat=false, batdau=false;
        private List<ListPid> listpid = new List<ListPid>();
        public static int VK_1 = 0x32;



        private long address_cancau=0,address_bongca=0;

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void load()
        {
            switch (cbb_gialap.SelectedIndex)
            {
                case 0:
                    nameproc = "HD-Player";

                    Process[] processes = Process.GetProcessesByName(nameproc);

                    if (processes.Length > 0)
                    {

                        foreach (Process process in processes)
                        {
                            var allchildwindows = new WindowHandleInfo(process.MainWindowHandle).GetAllChildHandles();

                            daco = false;
                            for (int i = 0; i < listpid.Count; i++)
                            {

                                if (process.Id.Equals(listpid[i].Pid))
                                {
                                    daco = true;
                                    break;
                                }
                            }
                            if (!daco)
                            {

                                listpid.Add(new ListPid(process.Id, process.MainWindowHandle, (IntPtr)allchildwindows[0], process.MainWindowTitle, false, false, false, false, 0, 0, 0, 0, 0));
                                listView1.Items.Add(listpid[listpid.Count - 1].Title);
                                listView1.Items[listView1.Items.Count - 1].SubItems.Add(listpid[listpid.Count - 1].Hwnd.ToString());
                                listView1.Items[listView1.Items.Count - 1].SubItems.Add(listpid[listpid.Count - 1].Pid.ToString());
                                listView1.Items[listView1.Items.Count - 1].SubItems.Add("");
                                daco = false;
                            }
                        }

                    }
                    break;
                case 1:
                    nameproc = "NoxVMHandle";
                    
                    Process[] processesNoxVMHandle = Process.GetProcessesByName(nameproc);
                    int pidNoxVMHandle;

                    foreach(Process process in processesNoxVMHandle)
                    {
                        daco = false;
                        pidNoxVMHandle = 0;
                        for (int i = 0; i < listpid.Count; i++)
                        {

                            if (process.Id.Equals(listpid[i].Pid))
                            {
                                daco = true;
                                break;
                            }
                        }
                        if (!daco)
                        {
                            pidNoxVMHandle = process.Id; 

                            Process[] processNox = Process.GetProcessesByName("Nox");
                            foreach(Process processnox in processNox)
                            {
                                var allchildwindows = new WindowHandleInfo(processnox.MainWindowHandle).GetAllChildHandles();
                                daco = false;
                                for (int i = 0; i < listpid.Count; i++)
                                {
                                    if ((IntPtr)allchildwindows[4] == listpid[i].Childhwnd)
                                    {
                                        daco = true;
                                        break;
                                    }
                                }
                                if (!daco)
                                {
                                    listpid.Add(new ListPid(pidNoxVMHandle, processnox.MainWindowHandle, (IntPtr)allchildwindows[4], processnox.MainWindowTitle, false, false, false, false, 0, 0, 0, 0, 0));
                                    listView1.Items.Add(listpid[listpid.Count - 1].Title);
                                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(listpid[listpid.Count - 1].Childhwnd.ToString());
                                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(listpid[listpid.Count - 1].Pid.ToString());
                                    listView1.Items[listView1.Items.Count - 1].SubItems.Add("");
                                    daco = false;
                                    break;
                                }
                            }
                        }
                    }

                    
                    break;
                case 2:
                    nameproc = "LdVBoxHeadless";
                    break;
                default:
                    break;
            }
            
            
        }

        /*
        private bool open_Proc()
        {
            openProc = mem.OpenProcess(pid);
            return openProc;
        }
        */

        /*
        private async Task scanaob_cancau()
        {
            IEnumerable<long> AoBScanResults;
            listpid[id].Address_cancau = 0;

            if (!openProc)
            {
                open_Proc();
            }
            AoBScanResults = await mem.AoBScan(aob_cancau, true, true);

            foreach (long res in AoBScanResults)
            {
                listpid[id].Address_cancau = res + 0x10;
            }
            if (listpid[id].Address_cancau == 0)
            {
                listpid[id].Kichhoat = false;

                MessageBox.Show("Kích hoạt cần câu không thành công");
            }

        }
        */


        /*
        private async Task scanaob_bongca()
        {

            IEnumerable<long> AoBScanResults;
            listpid[id].Address_bongca = 0;

            if (!openProc)
            {
                open_Proc();
            }
            AoBScanResults = await mem.AoBScan(aob_bongca, true, true);

            foreach (long res in AoBScanResults)
            {
                listpid[id].Address_bongca = res;
            }

            if (listpid[id].Address_bongca == 0)
            {
                listpid[id].Kichhoat = false;
                MessageBox.Show("Kích hoạt lọc bóng cá thất bại");
            }

        }
        */



        private void button1_Click(object sender, EventArgs e)
        {
            load();
            
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVjKpo3JvJm1vCLudw8Wc0A/featured");
        }

        private async void kichhoattask()
        {
            if (listpid[id].Kichhoat)
            {
                listpid[id].Kichhoat = false;
            }
            else
            {
                listpid[id].Kichhoat = true;
                
                RunCauCa runCauCa= new RunCauCa(listpid[id].Pid,listpid[id].Childhwnd,id,listpid);

                if (cb_locbongca.Checked)
                {
                    listpid[id].Address_bongca = await runCauCa.scanaob_bongca();

                    if (listpid[id].Address_bongca == 0)
                    {
                        MessageBox.Show("Kích hoạt lọc bóng cá thất bại. Bạn sẽ không lọc được bóng cá");
                    }
                }

                if (cb_tangtocdo.Checked)
                {
                    await runCauCa.scanaob_tangtoc();


                }

                listpid[id].Address_cancau = await runCauCa.scanaob_cancau();
                if (listpid[id].Address_cancau == 0)
                {
                    listpid[id].Kichhoat = false;
                }

                if (listpid[id].Kichhoat)
                {
                    lb_trangthaikichhoat.Invoke((MethodInvoker)delegate
                    {
                        lb_trangthaikichhoat.Text = "Đã kích hoạt";
                    });
                }
                else
                {
                    lb_trangthaikichhoat.Invoke((MethodInvoker)delegate
                    {
                        lb_trangthaikichhoat.Text = "Chưa kích hoạt";

                    });
                    MessageBox.Show("Kích hoạt thất bại. Bạn không thể bắt đầu câu cá.\n"+"Vui lòng kích hoạt lại");
                }
            }
        }

        private void bt_kichhoat_Click(object sender, EventArgs e)
        {
            new Thread(() => {
                kichhoattask();
            }).Start();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cbb_gialap.Items.Add("BlueStacks");
            cbb_gialap.Items.Add("Nox");
            cbb_gialap.Items.Add("LDPlayer");
            cbb_gialap.SelectedIndex = 0;

            cbb_bongca.Items.Add("Tất cả");
            cbb_bongca.Items.Add("Bóng 2");
            cbb_bongca.Items.Add("Bóng 3");
            cbb_bongca.Items.Add("Bóng 4");
            cbb_bongca.Items.Add("Bóng 5");
            cbb_bongca.SelectedIndex = 0;

            cbb_cancau.Items.Add("Cần câu 1");
            cbb_cancau.Items.Add("Cần câu 2");
            cbb_cancau.Items.Add("Cần câu 3");
            cbb_cancau.Items.Add("Cần câu 4");
            cbb_cancau.Items.Add("Cần câu 5");
            cbb_cancau.Items.Add("Cần câu 6");
            cbb_cancau.SelectedIndex = 0;

            groupBox1.Visible = false;
            load();



        }

        private void listView1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;


            id = listView1.SelectedItems[0].Index;
            pid = listpid[id].Pid;
            lb_pid.Text= pid.ToString();
            cb_locbongca.Checked = listpid[id].Locbong;
            cb_tangtocdo.Checked = listpid[id].Tangtocdo;
            cbb_bongca.SelectedIndex = listpid[id].Bongca;
            cbb_cancau.SelectedIndex = listpid[id].Cancau;
            numdelay.Value = listpid[id].Delay;

            if (listpid[id].Kichhoat)
            {
                lb_trangthaikichhoat.Text = "Đã kích hoạt";
            }
            else
            {
                lb_trangthaikichhoat.Text = "Chưa kích hoạt";
            }
            
            if (listpid[id].Batdau)
            {
                bt_batdau.Text = "Tạm dừng";
            }
            else
            {
                bt_batdau.Text = "Bắt đầu";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trangthaibatdau()
        {
            if (listpid[id].Batdau)
            {
                listView1.Items[id].SubItems[3].Text = "Đang chạy";
                listView1.Items[id].UseItemStyleForSubItems = false;
                listView1.Items[id].SubItems[3].ForeColor = Color.Green;


            }
            else
            {
                listView1.Items[id].SubItems[3].Text = "Tạm dừng";
                listView1.Items[id].UseItemStyleForSubItems = false;
                listView1.Items[id].SubItems[3].ForeColor = Color.Red;
            }
        }
        public int MakeLong(int lowPart, int highPart)
        {
            return (int)(((ushort)lowPart) | (uint)(highPart << 16));
        }

        public void click(int x, int y, IntPtr hwnd)
        {
            pos = MakeLong(x, y);

            SendMessage(hwnd, WM_LBUTTONDOWN, 0x00000001, pos);
            SendMessage(hwnd, WM_LBUTTONUP, 0x00000001, pos);
        }

        
        /*
        private void cauca(int threadid,IntPtr threadhwnd)
        {
            
            int trangthaicancau = 0; 
            int bongca = 0;
            bool thacan=false;
            long address_can = listpid[threadid].Address_cancau - 0x28;
            int cancauX=0;
            int cancauY=0;
            List<int> listbongca = new List<int>();


            switch (listpid[threadid].Cancau)
            {
                case 0:
                    cancauX = 678;
                    cancauY = 261;
                    break;
                case 1:
                    cancauX = 730;
                    cancauY = 261;
                    break;
                case 2:
                    cancauX = 880;
                    cancauY = 261;
                    break;
                case 3:
                    cancauX = 678;
                    cancauY = 455;
                    break;
                case 4:
                    cancauX = 730;
                    cancauY = 455;
                    break;
                case 5:
                    cancauX = 880;
                    cancauY = 455;
                    break;

            }

            while (listpid[threadid].Batdau)
            {
                Thread.Sleep(100);
                Thread.Sleep(listpid[threadid].Delay);

                trangthaicancau = mem.ReadInt(listpid[id].Address_cancau.ToString("x8"));
                bongca = mem.ReadInt(listpid[id].Address_bongca.ToString("x8"));

                switch (trangthaicancau)
                {
                    case 0:

                        if (mem.ReadInt(address_can.ToString("x8")) == 103)
                        {
                            //tha can
                            click(764, 330, threadhwnd);
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            //lay can
                            click(917, 289, threadhwnd);
                            Thread.Sleep(1000);
                            click(692, 41, threadhwnd);
                            Thread.Sleep(1000);
                            click(cancauX, cancauY, threadhwnd);
                            Thread.Sleep(500);
                            click(469,418,threadhwnd);
                        }
                        break;

                    case 3:
                        switch (listpid[threadid].Bongca)
                        {
                            case 0:
                                break;
                            case 1:
                                if (bongca == 1 || bongca == 7 || bongca == 13)
                                {
                                    Thread.Sleep(50);
                                    click(845, 430, threadhwnd);
                                }
                                break;
                            case 2:
                                if (bongca == 1 || bongca == 7 || bongca == 13 || bongca ==10 || bongca==15 )
                                {
                                    Thread.Sleep(50);
                                    click(845, 430, threadhwnd);
                                }
                                break;
                            case 3:
                                if(bongca < 17)
                                {
                                    Thread.Sleep(50);
                                    click(845, 430, threadhwnd);
                                }
                                break;
                            case 4:
                                if(bongca < 25)
                                {
                                    Thread.Sleep(50);
                                    click(845, 430, threadhwnd);
                                }
                                break;
                        }
                        Thread.Sleep(1000);
                        break;

                    case 4:
                        Thread.Sleep(50);
                        click(845, 430,threadhwnd);
                        break;
                    case 8:
                        Thread.Sleep(100);
                        click(748, 414, threadhwnd);
                        Thread.Sleep(1000);
                        break;
                    case 10:
                        Thread.Sleep(500);
                        click(917, 289,threadhwnd);
                        Thread.Sleep(300);
                        click(692, 41,threadhwnd);
                        Thread.Sleep(300);
                        click(cancauX, cancauY, threadhwnd);
                        Thread.Sleep(1000);
                        click(469, 418, threadhwnd);
                        Thread.Sleep(1000);
                        click(469, 418, threadhwnd);
                        Thread.Sleep(1000);
                        click(469, 418, threadhwnd);
                        Thread.Sleep(1000);
                        click(469, 418, threadhwnd);
                        break;
                    default:
                        break;
                }
            }
        }
        */

        private void batdaucauca()
        {
            RunCauCa runCauCa= new RunCauCa(listpid[id].Pid, listpid[id].Childhwnd, id, listpid);
            new Thread(() => runCauCa.cauca()).Start();
        }

        private void bt_batdau_Click(object sender, EventArgs e)
        {

            if (listpid[id].Kichhoat)
            {
                listpid[id].Batdau = !listpid[id].Batdau;
                if (listpid[id].Batdau)
                {
                    listpid[id].Locbong = cb_locbongca.Checked;
                    listpid[id].Tangtocdo = cb_tangtocdo.Checked;
                    listpid[id].Bongca = cbb_bongca.SelectedIndex;
                    listpid[id].Cancau = cbb_cancau.SelectedIndex;
                    listpid[id].Delay = (int)numdelay.Value;
                    batdaucauca();
                    bt_batdau.Text = "Tạm dừng";
                }
                else
                {
                    bt_batdau.Text = "Bắt đầu";
                }

                trangthaibatdau();
                
            }
            else
            {
                MessageBox.Show("Bạn cần phải kích hoạt trước khi bắt đầu");
            }

        }
    }
}
