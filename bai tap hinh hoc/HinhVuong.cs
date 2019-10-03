using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_hinh_hoc
{
    class HinhVuong: HinhCN
    {
        public float chuvi;
        public float dientich;

        public float Canh
        {
            get { return ChieuDai; }
            set { ChieuDai = value; }
        }

        public HinhVuong() { }

        public HinhVuong(float canh)
        {
            ChieuDai = canh;
        }

        public void ChuVi()
        {
            chuvi = Dai * 4;
        }
        public void DienTich()
        {
            dientich = Dai * Dai;
        }
    }
}
