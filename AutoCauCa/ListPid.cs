using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCauCa
{
    class ListPid
    {
        private int pid,bongca,delay,cancau;
        private IntPtr hwnd,childhwnd;
        private string title;
        private long address_cancau, address_bongca;
        private bool locbong, tangtocdo, kichhoat, batdau;

        public ListPid()
        {
        }

        public ListPid(int pid,IntPtr hwnd, IntPtr childhwnd,string title, bool locbong, bool tangtocdo, bool kichhoat, bool batdau, int bongca, long address_cancau, long address_bongca, int delay, int cancau)
        {
            this.pid = pid;
            this.hwnd = hwnd;
            this.childhwnd = childhwnd;
            this.title = title;
            this.locbong = locbong;
            this.tangtocdo = tangtocdo;
            this.kichhoat = kichhoat;
            this.batdau = batdau;
            this.bongca = bongca;
            this.address_cancau = address_cancau;
            this.address_bongca = address_bongca;
            this.delay = delay;
            this.cancau = cancau;
        }
        public int Pid {  get=> pid; set => pid = value; }
        public IntPtr Hwnd { get => hwnd; set => hwnd = value; }
        public IntPtr Childhwnd { get => childhwnd; set => childhwnd = value; }
        public string Title { get => title; set => title = value; }
        public bool Locbong { get => locbong; set => locbong = value; }
        public bool Tangtocdo { get => tangtocdo; set => tangtocdo = value; }
        public bool Kichhoat { get => kichhoat; set => kichhoat = value; }
        public bool Batdau { get => batdau; set => batdau = value; }
        public int Bongca { get => bongca; set => bongca = value; }
        public long Address_cancau { get => address_cancau; set => address_cancau = value; }
        public long Address_bongca { get => address_bongca; set => address_bongca = value; }
        public int Delay {  get => delay; set => delay = value;}
        public int Cancau { get => cancau; set => cancau = value; }

    }
}
