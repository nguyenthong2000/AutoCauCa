using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Memory;

namespace AutoCauCa
{
    class RunCauCa
    {
        private string aob_cancau = "10 80 00 03 10 00 00 00 00 80 00 03 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 ?? 01 01 00";
        private string aob_bongca = "00 00 00 00 20 ?6 ?? ?? 00 ?6 ?? ?? 88 ?1 ?? ?? 50 ?1 ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ?? 0? ?? ?? 00 00 00 00 00 00 00 00 ?0 ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 A0 ?F ?? A? 00 00 00 00 00 00 00 00 00 00 00 00 A0 ?B ?? ?? 80";
        private string aob_tangtoc = "00 00 00 00 00 00 F0 3F 00 00 00 00 01 00 00 00 01 01 00 00 FF FF FF FF 00 00 00 00 00 00 00 00 00 00 FF FF 00 00 00 00 ?? ?? ?? ?? 48 DE CE 04 1E 00 00 00 70 E9 CE 04";
        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_LBUTTONUP = 0x0202;
        Mem mem;
        
        private int _pid;
        private int _id;
        private IntPtr _hwnd;
        private bool _openProc;
        private List<ListPid> _list;


        int pos;
        public RunCauCa(int pid, IntPtr hwnd, int id, List<ListPid> list)
        {
            this._pid = pid;
            this._hwnd = hwnd;
            this._id = id;
            this._openProc = false;
            this._list=list;
            this.mem = new Mem();

        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void open_Proc()
        {
            this._openProc = this.mem.OpenProcess(this._pid);
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

        public async Task scanaob_tangtoc()
        {

            IEnumerable<long> AoBScanResults;
            if (!this._openProc)
            {
                open_Proc();
            }
            AoBScanResults = await this.mem.AoBScan(aob_tangtoc, true, true);

            foreach (long res in AoBScanResults)
            {
                this.mem.WriteMemory(res.ToString("x8"), "double", "9");
                Thread.Sleep(10);
            }
        }

        public async Task<long> scanaob_cancau()
        {
            IEnumerable<long> AoBScanResults;
            long Address_cancau = 0;
            if (!this._openProc)
            {
                open_Proc();
            }
            AoBScanResults = await this.mem.AoBScan(aob_cancau, true, true);

            foreach (long res in AoBScanResults)
            {
                Address_cancau = res + 0x10;
            }
            return Address_cancau;
        }

        public async Task<long> scanaob_bongca()
        {
            IEnumerable<long> AoBScanResults;
            long Address_bongca = 0;

            if (!this._openProc)
            {
                open_Proc();
            }
            AoBScanResults = await this.mem.AoBScan(aob_bongca, true, true);

            foreach (long res in AoBScanResults)
            {
                Address_bongca = res;
                
            }
            return Address_bongca;
        }

        public void cauca()
        {
            if (!this._openProc)
            {
                open_Proc();
            }
            int trangthaicancau = 0;
            int bongca = 0;
            bool thacan = false;
            long address_can = this._list[this._id].Address_cancau - 0x28;
            int cancauX = 0;
            int cancauY = 0;
            List<int> listbongca = new List<int>();


            switch (this._list[this._id].Cancau)
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

            while (this._list[this._id].Batdau)
            {
                Thread.Sleep(50);
 
                trangthaicancau = this.mem.ReadInt(this._list[this._id].Address_cancau.ToString("x8"));
                bongca = this.mem.ReadInt(this._list[this._id].Address_bongca.ToString("x8"));

                switch (trangthaicancau)
                {
                    case 0:

                        if (this.mem.ReadInt(address_can.ToString("x8")) == 103)
                        {
                            //tha can
                            click(764, 330, this._hwnd);
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            //lay can
                            click(917, 289, this._hwnd);
                            Thread.Sleep(1000);
                            click(692, 41, this._hwnd);
                            Thread.Sleep(1000);
                            click(cancauX, cancauY, this._hwnd);
                            Thread.Sleep(500);
                            click(469, 418, this._hwnd);
                        }
                        break;

                    case 3:
                        switch (this._list[this._id].Bongca)
                        {
                            case 0:
                                break;
                            case 1:
                                if (bongca == 1 || bongca == 7 || bongca == 13)
                                {
                                    Thread.Sleep(50);
                                    click(845, 430, this._hwnd);
                                    Thread.Sleep(1000);
                                }
                                break;
                            case 2:
                                if (bongca == 1 || bongca == 7 || bongca == 13 || bongca == 10 || bongca == 15)
                                {
                                    Thread.Sleep(50);
                                    click(845, 430, this._hwnd);
                                    Thread.Sleep(1000);
                                }
                                break;
                            case 3:
                                if (bongca < 17)
                                {
                                    Thread.Sleep(50);
                                    click(845, 430, this._hwnd);
                                    Thread.Sleep(1000);
                                }
                                break;
                            case 4:
                                if (bongca < 25)
                                {
                                    Thread.Sleep(50);
                                    click(845, 430, this._hwnd);
                                    Thread.Sleep(1000);
                                }
                                break;
                        }
                        break;

                    case 4:
                        click(845, 430, this._hwnd);
                        break;
                    case 8:
                        Thread.Sleep(100);
                        click(748, 414, this._hwnd);
                        Thread.Sleep(1000);
                        break;
                    case 10:
                        Thread.Sleep(1000);
                        click(917, 289, this._hwnd);
                        Thread.Sleep(1000);
                        click(692, 41, this._hwnd);
                        Thread.Sleep(1000);
                        click(cancauX, cancauY, this._hwnd);
                        Thread.Sleep(1000);
                        click(469, 418, this._hwnd);
                        Thread.Sleep(1000);
                        click(469, 418, this._hwnd);
                        Thread.Sleep(1000);
                        click(469, 418, this._hwnd);
                        Thread.Sleep(1000);
                        click(469, 418, this._hwnd);
                        break;
                    default:
                        break;
                }
            }
        }



    }
}
