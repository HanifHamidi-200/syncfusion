using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEUL
{
    public partial class Form1 : Form
    {
        private int mnSelect1, mnSelect2;
        private bool mbSelectFirst;
        private List<bool> T1_null = new List<bool> { false,false,false,false,false,false };
        private List<int> T1_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T1_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T1_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T2_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T2_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T2_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T2_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T3_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T3_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T3_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T3_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T4_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T4_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T4_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T4_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T5_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T5_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T5_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T5_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T6_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T6_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T6_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T6_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T7_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T7_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T7_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T7_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> T8_null = new List<bool> { false, false, false, false, false, false };
        private List<int> T8_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T8_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> T8_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A1_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A1_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A1_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A1_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A2_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A2_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A2_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A2_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A3_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A3_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A3_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A3_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A4_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A4_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A4_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A4_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A5_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A5_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A5_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A5_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> A6_null = new List<bool> { false, false, false, false, false, false };
        private List<int> A6_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A6_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> A6_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B1_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B1_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B1_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B1_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B2_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B2_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B2_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B2_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B3_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B3_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B3_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B3_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B4_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B4_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B4_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B4_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B5_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B5_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B5_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B5_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> B6_null = new List<bool> { false, false, false, false, false, false };
        private List<int> B6_method = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B6_order = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> B6_index = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<bool> C1_null = new List<bool> { false, false, false, false};
        private List<int> C1_method = new List<int> { 0, 0, 0, 0 };
        private List<int> C1_order = new List<int> { 0, 0, 0, 0};
        private List<int> C1_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> C2_null = new List<bool> { false, false, false, false};
        private List<int> C2_method = new List<int> { 0, 0, 0, 0};
        private List<int> C2_order = new List<int> { 0, 0, 0, 0 };
        private List<int> C2_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> C3_null = new List<bool> { false, false, false, false};
        private List<int> C3_method = new List<int> { 0, 0, 0, 0 };
        private List<int> C3_order = new List<int> { 0, 0, 0, 0 };
        private List<int> C3_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> C4_null = new List<bool> { false, false, false, false};
        private List<int> C4_method = new List<int> { 0, 0, 0, 0 };
        private List<int> C4_order = new List<int> { 0, 0, 0, 0 };
        private List<int> C4_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> C5_null = new List<bool> { false, false, false, false};
        private List<int> C5_method = new List<int> { 0, 0, 0, 0 };
        private List<int> C5_order = new List<int> { 0, 0, 0, 0};
        private List<int> C5_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> C6_null = new List<bool> { false, false, false, false };
        private List<int> C6_method = new List<int> { 0, 0, 0, 0 };
        private List<int> C6_order = new List<int> { 0, 0, 0, 0 };
        private List<int> C6_index = new List<int> { 0, 0, 0, 0 };
        private List<bool> E1_null = new List<bool> { false };
        private List<int> E1_method = new List<int> { 0 };
        private List<int> E1_order = new List<int> { 0 };
        private List<int> E1_index = new List<int> { 0 };
        private List<bool> E2_null = new List<bool> { false};
        private List<int> E2_method = new List<int> { 0 };
        private List<int> E2_order = new List<int> { 0 };
        private List<int> E2_index = new List<int> { 0 };
        private List<bool> E3_null = new List<bool> { false };
        private List<int> E3_method = new List<int> { 0 };
        private List<int> E3_order = new List<int> { 0 };
        private List<int> E3_index = new List<int> { 0 };
        private List<bool> E4_null = new List<bool> { false};
        private List<int> E4_method = new List<int> { 0 };
        private List<int> E4_order = new List<int> { 0 };
        private List<int> E4_index = new List<int> { 0 };

        private bool fValidCombo(int nSelect1,int nSelect2)
        {
            switch (nSelect1)
            {
                case 11:
                    switch (nSelect2)
                    {
                        case 21:
                            return true;
                        case 22:
                            return true;
                        case 23:
                            return true;
                        case 24:
                            return true;
                        case 25:
                            return true;
                        case 26:
                            return true;
                        default:
                            return false;
                    }
                case 12:
                    switch (nSelect2)
                    {
                        case 21:
                            return true;
                        case 22:
                            return true;
                        case 23:
                            return true;
                        case 24:
                            return true;
                        case 25:
                            return true;
                        case 26:
                            return true;
                        default:
                            return false;
                    }
                case 13:
                    switch (nSelect2)
                    {
                        case 21:
                            return true;
                        case 22:
                            return true;
                        case 23:
                            return true;
                        case 24:
                            return true;
                        case 25:
                            return true;
                        case 26:
                            return true;
                        default:
                            return false;
                    }
                case 14:
                    switch (nSelect2)
                    {
                        case 21:
                            return true;
                        case 22:
                            return true;
                        case 23:
                            return true;
                        case 24:
                            return true;
                        case 25:
                            return true;
                        case 26:
                            return true;
                        default:
                            return false;
                    }
                case 15:
                    switch (nSelect2)
                    {
                        case 21:
                            return true;
                        case 22:
                            return true;
                        case 23:
                            return true;
                        case 24:
                            return true;
                        case 25:
                            return true;
                        case 26:
                            return true;
                        default:
                            return false;
                    }
                case 16:
                    switch (nSelect2)
                    {
                        case 21:
                            return true;
                        case 22:
                            return true;
                        case 23:
                            return true;
                        case 24:
                            return true;
                        case 25:
                            return true;
                        case 26:
                            return true;
                        default:
                            return false;
                    }
                case 17:
                    switch (nSelect2)
                    {
                        case 21:
                            return true;
                        case 22:
                            return true;
                        case 23:
                            return true;
                        case 24:
                            return true;
                        case 25:
                            return true;
                        case 26:
                            return true;
                        default:
                            return false;
                    }
                case 18:
                    switch (nSelect2)
                    {
                        case 21:
                            return true;
                        case 22:
                            return true;
                        case 23:
                            return true;
                        case 24:
                            return true;
                        case 25:
                            return true;
                        case 26:
                            return true;
                        default:
                            return false;
                    }
                case 21:
                    switch (nSelect2)
                    {
                        case 31:
                            return true;
                        case 32:
                            return true;
                        case 33:
                            return true;
                        case 34:
                            return true;
                        case 35:
                            return true;
                        case 36:
                            return true;
                        default:
                            return false;
                    }
                case 22:
                    switch (nSelect2)
                    {
                        case 31:
                            return true;
                        case 32:
                            return true;
                        case 33:
                            return true;
                        case 34:
                            return true;
                        case 35:
                            return true;
                        case 36:
                            return true;
                        default:
                            return false;
                    }
                case 23:
                    switch (nSelect2)
                    {
                        case 31:
                            return true;
                        case 32:
                            return true;
                        case 33:
                            return true;
                        case 34:
                            return true;
                        case 35:
                            return true;
                        case 36:
                            return true;
                        default:
                            return false;
                    }
                case 24:
                    switch (nSelect2)
                    {
                        case 31:
                            return true;
                        case 32:
                            return true;
                        case 33:
                            return true;
                        case 34:
                            return true;
                        case 35:
                            return true;
                        case 36:
                            return true;
                        default:
                            return false;
                    }
                case 25:
                    switch (nSelect2)
                    {
                        case 31:
                            return true;
                        case 32:
                            return true;
                        case 33:
                            return true;
                        case 34:
                            return true;
                        case 35:
                            return true;
                        case 36:
                            return true;
                        default:
                            return false;
                    }
                case 26:
                    switch (nSelect2)
                    {
                        case 31:
                            return true;
                        case 32:
                            return true;
                        case 33:
                            return true;
                        case 34:
                            return true;
                        case 35:
                            return true;
                        case 36:
                            return true;
                        default:
                            return false;
                    }
                case 31:
                    switch (nSelect2)
                    {
                        case 41:
                            return true;
                        case 42:
                            return true;
                        case 43:
                            return true;
                        case 44:
                            return true;
                        case 45:
                            return true;
                        case 46:
                            return true;
                        default:
                            return false;
                    }
                case 32:
                    switch (nSelect2)
                    {
                        case 41:
                            return true;
                        case 42:
                            return true;
                        case 43:
                            return true;
                        case 44:
                            return true;
                        case 45:
                            return true;
                        case 46:
                            return true;
                        default:
                            return false;
                    }
                case 33:
                    switch (nSelect2)
                    {
                        case 41:
                            return true;
                        case 42:
                            return true;
                        case 43:
                            return true;
                        case 44:
                            return true;
                        case 45:
                            return true;
                        case 46:
                            return true;
                        default:
                            return false;
                    }
                case 34:
                    switch (nSelect2)
                    {
                        case 41:
                            return true;
                        case 42:
                            return true;
                        case 43:
                            return true;
                        case 44:
                            return true;
                        case 45:
                            return true;
                        case 46:
                            return true;
                        default:
                            return false;
                    }
                case 35:
                    switch (nSelect2)
                    {
                        case 41:
                            return true;
                        case 42:
                            return true;
                        case 43:
                            return true;
                        case 44:
                            return true;
                        case 45:
                            return true;
                        case 46:
                            return true;
                        default:
                            return false;
                    }
                case 36:
                    switch (nSelect2)
                    {
                        case 41:
                            return true;
                        case 42:
                            return true;
                        case 43:
                            return true;
                        case 44:
                            return true;
                        case 45:
                            return true;
                        case 46:
                            return true;
                        default:
                            return false;
                    }
                case 41:
                    switch (nSelect2)
                    {
                        case 51:
                            return true;
                        case 52:
                            return true;
                        case 53:
                            return true;
                        case 54:
                            return true;
                        default:
                            return false;
                    }
                case 42:
                    switch (nSelect2)
                    {
                        case 51:
                            return true;
                        case 52:
                            return true;
                        case 53:
                            return true;
                        case 54:
                            return true;
                        default:
                            return false;
                    }
                case 43:
                    switch (nSelect2)
                    {
                        case 51:
                            return true;
                        case 52:
                            return true;
                        case 53:
                            return true;
                        case 54:
                            return true;
                        default:
                            return false;
                    }
                case 44:
                    switch (nSelect2)
                    {
                        case 51:
                            return true;
                        case 52:
                            return true;
                        case 53:
                            return true;
                        case 54:
                            return true;
                        default:
                            return false;
                    }
                case 45:
                    switch (nSelect2)
                    {
                        case 51:
                            return true;
                        case 52:
                            return true;
                        case 53:
                            return true;
                        case 54:
                            return true;
                        default:
                            return false;
                    }
                case 46:
                    switch (nSelect2)
                    {
                        case 51:
                            return true;
                        case 52:
                            return true;
                        case 53:
                            return true;
                        case 54:
                            return true;
                        default:
                            return false;
                    }
                case 51:
                    switch (nSelect2)
                    {
                        case 51:
                            return true;
                        default:
                            return false;
                    }
                case 52:
                    switch (nSelect2)
                    {
                        case 52:
                            return true;
                        default:
                            return false;
                    }
                case 53:
                    switch (nSelect2)
                    {
                        case 53:
                            return true;
                        default:
                            return false;
                    }
                case 54:
                    switch (nSelect2)
                    {
                        case 54:
                            return true;
                        default:
                            return false;
                    }
              }

            return false;
        }

        private void fSave()
        {
            bool bValidCombo = fValidCombo(mnSelect1, mnSelect2);

            if (bValidCombo == false)
            {
                MessageBox.Show("Error!");
                return;
            }

            switch (mnSelect1)
            {
                case 11:
                    switch (mnSelect2)
                    {
                        case 21:
                            T1_null[0] = chkNull.Checked;
                            T1_method[0] = lstMethod.SelectedIndex + 1;
                            T1_order[0] = lstOrder.SelectedIndex + 1;
                            T1_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 22:
                            T1_null[1] = chkNull.Checked;
                            T1_method[1] = lstMethod.SelectedIndex + 1;
                            T1_order[1] = lstOrder.SelectedIndex + 1;
                            T1_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 23:
                            T1_null[2] = chkNull.Checked;
                            T1_method[2] = lstMethod.SelectedIndex + 1;
                            T1_order[2] = lstOrder.SelectedIndex + 1;
                            T1_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 24:
                            T1_null[3] = chkNull.Checked;
                            T1_method[3] = lstMethod.SelectedIndex + 1;
                            T1_order[3] = lstOrder.SelectedIndex + 1;
                            T1_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 25:
                            T1_null[4] = chkNull.Checked;
                            T1_method[4] = lstMethod.SelectedIndex + 1;
                            T1_order[4] = lstOrder.SelectedIndex + 1;
                            T1_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 26:
                            T1_null[5] = chkNull.Checked;
                            T1_method[5] = lstMethod.SelectedIndex + 1;
                            T1_order[5] = lstOrder.SelectedIndex + 1;
                            T1_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                    break;
                case 12:
                    switch (mnSelect2)
                    {
                        case 21:
                            T2_null[0] = chkNull.Checked;
                            T2_method[0] = lstMethod.SelectedIndex + 1;
                            T2_order[0] = lstOrder.SelectedIndex + 1;
                            T2_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 22:
                            T2_null[1] = chkNull.Checked;
                            T2_method[1] = lstMethod.SelectedIndex + 1;
                            T2_order[1] = lstOrder.SelectedIndex + 1;
                            T2_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 23:
                            T2_null[2] = chkNull.Checked;
                            T2_method[2] = lstMethod.SelectedIndex + 1;
                            T2_order[2] = lstOrder.SelectedIndex + 1;
                            T2_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 24:
                            T2_null[3] = chkNull.Checked;
                            T2_method[3] = lstMethod.SelectedIndex + 1;
                            T2_order[3] = lstOrder.SelectedIndex + 1;
                            T2_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 25:
                            T2_null[4] = chkNull.Checked;
                            T2_method[4] = lstMethod.SelectedIndex + 1;
                            T2_order[4] = lstOrder.SelectedIndex + 1;
                            T2_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 26:
                            T2_null[5] = chkNull.Checked;
                            T2_method[5] = lstMethod.SelectedIndex + 1;
                            T2_order[5] = lstOrder.SelectedIndex + 1;
                            T2_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                    break;
                case 13:
                    switch (mnSelect2)
                    {
                        case 21:
                            T3_null[0] = chkNull.Checked;
                            T3_method[0] = lstMethod.SelectedIndex + 1;
                            T3_order[0] = lstOrder.SelectedIndex + 1;
                            T3_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 22:
                            T3_null[1] = chkNull.Checked;
                            T3_method[1] = lstMethod.SelectedIndex + 1;
                            T3_order[1] = lstOrder.SelectedIndex + 1;
                            T3_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 23:
                            T3_null[2] = chkNull.Checked;
                            T3_method[2] = lstMethod.SelectedIndex + 1;
                            T3_order[2] = lstOrder.SelectedIndex + 1;
                            T3_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 24:
                            T3_null[3] = chkNull.Checked;
                            T3_method[3] = lstMethod.SelectedIndex + 1;
                            T3_order[3] = lstOrder.SelectedIndex + 1;
                            T3_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 25:
                            T3_null[4] = chkNull.Checked;
                            T3_method[4] = lstMethod.SelectedIndex + 1;
                            T3_order[4] = lstOrder.SelectedIndex + 1;
                            T3_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 26:
                            T3_null[5] = chkNull.Checked;
                            T3_method[5] = lstMethod.SelectedIndex + 1;
                            T3_order[5] = lstOrder.SelectedIndex + 1;
                            T3_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                    break;
                case 14:
                    switch (mnSelect2)
                    {
                        case 21:
                            T4_null[0] = chkNull.Checked;
                            T4_method[0] = lstMethod.SelectedIndex + 1;
                            T4_order[0] = lstOrder.SelectedIndex + 1;
                            T4_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 22:
                            T4_null[1] = chkNull.Checked;
                            T4_method[1] = lstMethod.SelectedIndex + 1;
                            T4_order[1] = lstOrder.SelectedIndex + 1;
                            T4_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 23:
                            T4_null[2] = chkNull.Checked;
                            T4_method[2] = lstMethod.SelectedIndex + 1;
                            T4_order[2] = lstOrder.SelectedIndex + 1;
                            T4_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 24:
                            T4_null[3] = chkNull.Checked;
                            T4_method[3] = lstMethod.SelectedIndex + 1;
                            T4_order[3] = lstOrder.SelectedIndex + 1;
                            T4_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 25:
                            T4_null[4] = chkNull.Checked;
                            T4_method[4] = lstMethod.SelectedIndex + 1;
                            T4_order[4] = lstOrder.SelectedIndex + 1;
                            T4_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 26:
                            T4_null[5] = chkNull.Checked;
                            T4_method[5] = lstMethod.SelectedIndex + 1;
                            T4_order[5] = lstOrder.SelectedIndex + 1;
                            T4_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                    break;
                case 15:
                    switch (mnSelect2)
                    {
                        case 21:
                            T5_null[0] = chkNull.Checked;
                            T5_method[0] = lstMethod.SelectedIndex + 1;
                            T5_order[0] = lstOrder.SelectedIndex + 1;
                            T5_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 22:
                            T5_null[1] = chkNull.Checked;
                            T5_method[1] = lstMethod.SelectedIndex + 1;
                            T5_order[1] = lstOrder.SelectedIndex + 1;
                            T5_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 23:
                            T5_null[2] = chkNull.Checked;
                            T5_method[2] = lstMethod.SelectedIndex + 1;
                            T5_order[2] = lstOrder.SelectedIndex + 1;
                            T5_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 24:
                            T5_null[3] = chkNull.Checked;
                            T5_method[3] = lstMethod.SelectedIndex + 1;
                            T5_order[3] = lstOrder.SelectedIndex + 1;
                            T5_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 25:
                            T5_null[4] = chkNull.Checked;
                            T5_method[4] = lstMethod.SelectedIndex + 1;
                            T5_order[4] = lstOrder.SelectedIndex + 1;
                            T5_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 26:
                            T5_null[5] = chkNull.Checked;
                            T5_method[5] = lstMethod.SelectedIndex + 1;
                            T5_order[5] = lstOrder.SelectedIndex + 1;
                            T5_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                    break;
                case 16:
                    switch (mnSelect2)
                    {
                        case 21:
                            T6_null[0] = chkNull.Checked;
                            T6_method[0] = lstMethod.SelectedIndex + 1;
                            T6_order[0] = lstOrder.SelectedIndex + 1;
                            T6_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 22:
                            T6_null[1] = chkNull.Checked;
                            T6_method[1] = lstMethod.SelectedIndex + 1;
                            T6_order[1] = lstOrder.SelectedIndex + 1;
                            T6_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 23:
                            T6_null[2] = chkNull.Checked;
                            T6_method[2] = lstMethod.SelectedIndex + 1;
                            T6_order[2] = lstOrder.SelectedIndex + 1;
                            T6_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 24:
                            T6_null[3] = chkNull.Checked;
                            T6_method[3] = lstMethod.SelectedIndex + 1;
                            T6_order[3] = lstOrder.SelectedIndex + 1;
                            T6_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 25:
                            T6_null[4] = chkNull.Checked;
                            T6_method[4] = lstMethod.SelectedIndex + 1;
                            T6_order[4] = lstOrder.SelectedIndex + 1;
                            T6_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 26:
                            T6_null[5] = chkNull.Checked;
                            T6_method[5] = lstMethod.SelectedIndex + 1;
                            T6_order[5] = lstOrder.SelectedIndex + 1;
                            T6_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                    break;
                case 17:
                    switch (mnSelect2)
                    {
                        case 21:
                            T7_null[0] = chkNull.Checked;
                            T7_method[0] = lstMethod.SelectedIndex + 1;
                            T7_order[0] = lstOrder.SelectedIndex + 1;
                            T7_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 22:
                            T7_null[1] = chkNull.Checked;
                            T7_method[1] = lstMethod.SelectedIndex + 1;
                            T7_order[1] = lstOrder.SelectedIndex + 1;
                            T7_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 23:
                            T7_null[2] = chkNull.Checked;
                            T7_method[2] = lstMethod.SelectedIndex + 1;
                            T7_order[2] = lstOrder.SelectedIndex + 1;
                            T7_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 24:
                            T7_null[3] = chkNull.Checked;
                            T7_method[3] = lstMethod.SelectedIndex + 1;
                            T7_order[3] = lstOrder.SelectedIndex + 1;
                            T7_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 25:
                            T7_null[4] = chkNull.Checked;
                            T7_method[4] = lstMethod.SelectedIndex + 1;
                            T7_order[4] = lstOrder.SelectedIndex + 1;
                            T7_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 26:
                            T7_null[5] = chkNull.Checked;
                            T7_method[5] = lstMethod.SelectedIndex + 1;
                            T7_order[5] = lstOrder.SelectedIndex + 1;
                            T7_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                    break;
                case 18:
                    switch (mnSelect2)
                    {
                        case 21:
                            T8_null[0] = chkNull.Checked;
                            T8_method[0] = lstMethod.SelectedIndex + 1;
                            T8_order[0] = lstOrder.SelectedIndex + 1;
                            T8_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 22:
                            T8_null[1] = chkNull.Checked;
                            T8_method[1] = lstMethod.SelectedIndex + 1;
                            T8_order[1] = lstOrder.SelectedIndex + 1;
                            T8_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 23:
                            T8_null[2] = chkNull.Checked;
                            T8_method[2] = lstMethod.SelectedIndex + 1;
                            T8_order[2] = lstOrder.SelectedIndex + 1;
                            T8_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 24:
                            T8_null[3] = chkNull.Checked;
                            T8_method[3] = lstMethod.SelectedIndex + 1;
                            T8_order[3] = lstOrder.SelectedIndex + 1;
                            T8_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 25:
                            T8_null[4] = chkNull.Checked;
                            T8_method[4] = lstMethod.SelectedIndex + 1;
                            T8_order[4] = lstOrder.SelectedIndex + 1;
                            T8_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 26:
                            T8_null[5] = chkNull.Checked;
                            T8_method[5] = lstMethod.SelectedIndex + 1;
                            T8_order[5] = lstOrder.SelectedIndex + 1;
                            T8_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                    break;
                case 21:
                    switch (mnSelect2)
                    {
                        case 31:
                            A1_null[0] = chkNull.Checked;
                            A1_method[0] = lstMethod.SelectedIndex + 1;
                            A1_order[0] = lstOrder.SelectedIndex + 1;
                            A1_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 32:
                            A1_null[1] = chkNull.Checked;
                            A1_method[1] = lstMethod.SelectedIndex + 1;
                            A1_order[1] = lstOrder.SelectedIndex + 1;
                            A1_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 33:
                            A1_null[2] = chkNull.Checked;
                            A1_method[2] = lstMethod.SelectedIndex + 1;
                            A1_order[2] = lstOrder.SelectedIndex + 1;
                            A1_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 34:
                            A1_null[3] = chkNull.Checked;
                            A1_method[3] = lstMethod.SelectedIndex + 1;
                            A1_order[3] = lstOrder.SelectedIndex + 1;
                            A1_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 35:
                            A1_null[4] = chkNull.Checked;
                            A1_method[4] = lstMethod.SelectedIndex + 1;
                            A1_order[4] = lstOrder.SelectedIndex + 1;
                            A1_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 36:
                            A1_null[5] = chkNull.Checked;
                            A1_method[5] = lstMethod.SelectedIndex + 1;
                            A1_order[5] = lstOrder.SelectedIndex + 1;
                            A1_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                case 22:
                    switch (mnSelect2)
                    {
                        case 31:
                            A2_null[0] = chkNull.Checked;
                            A2_method[0] = lstMethod.SelectedIndex + 1;
                            A2_order[0] = lstOrder.SelectedIndex + 1;
                            A2_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 32:
                            A2_null[1] = chkNull.Checked;
                            A2_method[1] = lstMethod.SelectedIndex + 1;
                            A2_order[1] = lstOrder.SelectedIndex + 1;
                            A2_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 33:
                            A2_null[2] = chkNull.Checked;
                            A2_method[2] = lstMethod.SelectedIndex + 1;
                            A2_order[2] = lstOrder.SelectedIndex + 1;
                            A2_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 34:
                            A2_null[3] = chkNull.Checked;
                            A2_method[3] = lstMethod.SelectedIndex + 1;
                            A2_order[3] = lstOrder.SelectedIndex + 1;
                            A2_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 35:
                            A2_null[4] = chkNull.Checked;
                            A2_method[4] = lstMethod.SelectedIndex + 1;
                            A2_order[4] = lstOrder.SelectedIndex + 1;
                            A2_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 36:
                            A2_null[5] = chkNull.Checked;
                            A2_method[5] = lstMethod.SelectedIndex + 1;
                            A2_order[5] = lstOrder.SelectedIndex + 1;
                            A2_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                case 23:
                    switch (mnSelect2)
                    {
                        case 31:
                            A3_null[0] = chkNull.Checked;
                            A3_method[0] = lstMethod.SelectedIndex + 1;
                            A3_order[0] = lstOrder.SelectedIndex + 1;
                            A3_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 32:
                            A3_null[1] = chkNull.Checked;
                            A3_method[1] = lstMethod.SelectedIndex + 1;
                            A3_order[1] = lstOrder.SelectedIndex + 1;
                            A3_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 33:
                            A3_null[2] = chkNull.Checked;
                            A3_method[2] = lstMethod.SelectedIndex + 1;
                            A3_order[2] = lstOrder.SelectedIndex + 1;
                            A3_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 34:
                            A3_null[3] = chkNull.Checked;
                            A3_method[3] = lstMethod.SelectedIndex + 1;
                            A3_order[3] = lstOrder.SelectedIndex + 1;
                            A3_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 35:
                            A3_null[4] = chkNull.Checked;
                            A3_method[4] = lstMethod.SelectedIndex + 1;
                            A3_order[4] = lstOrder.SelectedIndex + 1;
                            A3_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 36:
                            A3_null[5] = chkNull.Checked;
                            A3_method[5] = lstMethod.SelectedIndex + 1;
                            A3_order[5] = lstOrder.SelectedIndex + 1;
                            A3_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                case 24:
                    switch (mnSelect2)
                    {
                        case 31:
                            A4_null[0] = chkNull.Checked;
                            A4_method[0] = lstMethod.SelectedIndex + 1;
                            A4_order[0] = lstOrder.SelectedIndex + 1;
                            A4_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 32:
                            A4_null[1] = chkNull.Checked;
                            A4_method[1] = lstMethod.SelectedIndex + 1;
                            A4_order[1] = lstOrder.SelectedIndex + 1;
                            A4_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 33:
                            A4_null[2] = chkNull.Checked;
                            A4_method[2] = lstMethod.SelectedIndex + 1;
                            A4_order[2] = lstOrder.SelectedIndex + 1;
                            A4_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 34:
                            A4_null[3] = chkNull.Checked;
                            A4_method[3] = lstMethod.SelectedIndex + 1;
                            A4_order[3] = lstOrder.SelectedIndex + 1;
                            A4_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 35:
                            A4_null[4] = chkNull.Checked;
                            A4_method[4] = lstMethod.SelectedIndex + 1;
                            A4_order[4] = lstOrder.SelectedIndex + 1;
                            A4_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 36:
                            A4_null[5] = chkNull.Checked;
                            A4_method[5] = lstMethod.SelectedIndex + 1;
                            A4_order[5] = lstOrder.SelectedIndex + 1;
                            A4_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                case 25:
                    switch (mnSelect2)
                    {
                        case 31:
                            A5_null[0] = chkNull.Checked;
                            A5_method[0] = lstMethod.SelectedIndex + 1;
                            A5_order[0] = lstOrder.SelectedIndex + 1;
                            A5_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 32:
                            A5_null[1] = chkNull.Checked;
                            A5_method[1] = lstMethod.SelectedIndex + 1;
                            A5_order[1] = lstOrder.SelectedIndex + 1;
                            A5_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 33:
                            A5_null[2] = chkNull.Checked;
                            A5_method[2] = lstMethod.SelectedIndex + 1;
                            A5_order[2] = lstOrder.SelectedIndex + 1;
                            A5_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 34:
                            A5_null[3] = chkNull.Checked;
                            A5_method[3] = lstMethod.SelectedIndex + 1;
                            A5_order[3] = lstOrder.SelectedIndex + 1;
                            A5_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 35:
                            A5_null[4] = chkNull.Checked;
                            A5_method[4] = lstMethod.SelectedIndex + 1;
                            A5_order[4] = lstOrder.SelectedIndex + 1;
                            A5_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 36:
                            A5_null[5] = chkNull.Checked;
                            A5_method[5] = lstMethod.SelectedIndex + 1;
                            A5_order[5] = lstOrder.SelectedIndex + 1;
                            A5_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                case 26:
                    switch (mnSelect2)
                    {
                        case 31:
                            A6_null[0] = chkNull.Checked;
                            A6_method[0] = lstMethod.SelectedIndex + 1;
                            A6_order[0] = lstOrder.SelectedIndex + 1;
                            A6_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 32:
                            A6_null[1] = chkNull.Checked;
                            A6_method[1] = lstMethod.SelectedIndex + 1;
                            A6_order[1] = lstOrder.SelectedIndex + 1;
                            A6_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 33:
                            A6_null[2] = chkNull.Checked;
                            A6_method[2] = lstMethod.SelectedIndex + 1;
                            A6_order[2] = lstOrder.SelectedIndex + 1;
                            A6_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 34:
                            A6_null[3] = chkNull.Checked;
                            A6_method[3] = lstMethod.SelectedIndex + 1;
                            A6_order[3] = lstOrder.SelectedIndex + 1;
                            A6_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 35:
                            A6_null[4] = chkNull.Checked;
                            A6_method[4] = lstMethod.SelectedIndex + 1;
                            A6_order[4] = lstOrder.SelectedIndex + 1;
                            A6_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 36:
                            A6_null[5] = chkNull.Checked;
                            A6_method[5] = lstMethod.SelectedIndex + 1;
                            A6_order[5] = lstOrder.SelectedIndex + 1;
                            A6_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }

                //3
                case 31:
                    switch (mnSelect2)
                    {
                        case 41:
                            B1_null[0] = chkNull.Checked;
                            B1_method[0] = lstMethod.SelectedIndex + 1;
                            B1_order[0] = lstOrder.SelectedIndex + 1;
                            B1_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 42:
                            B1_null[1] = chkNull.Checked;
                            B1_method[1] = lstMethod.SelectedIndex + 1;
                            B1_order[1] = lstOrder.SelectedIndex + 1;
                            B1_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 43:
                            B1_null[2] = chkNull.Checked;
                            B1_method[2] = lstMethod.SelectedIndex + 1;
                            B1_order[2] = lstOrder.SelectedIndex + 1;
                            B1_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 44:
                            B1_null[3] = chkNull.Checked;
                            B1_method[3] = lstMethod.SelectedIndex + 1;
                            B1_order[3] = lstOrder.SelectedIndex + 1;
                            B1_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 45:
                            B1_null[4] = chkNull.Checked;
                            B1_method[4] = lstMethod.SelectedIndex + 1;
                            B1_order[4] = lstOrder.SelectedIndex + 1;
                            B1_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 46:
                            B1_null[5] = chkNull.Checked;
                            B1_method[5] = lstMethod.SelectedIndex + 1;
                            B1_order[5] = lstOrder.SelectedIndex + 1;
                            B1_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                case 32:
                    switch (mnSelect2)
                    {
                        case 41:
                            B2_null[0] = chkNull.Checked;
                            B2_method[0] = lstMethod.SelectedIndex + 1;
                            B2_order[0] = lstOrder.SelectedIndex + 1;
                            B2_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 42:
                            B2_null[1] = chkNull.Checked;
                            B2_method[1] = lstMethod.SelectedIndex + 1;
                            B2_order[1] = lstOrder.SelectedIndex + 1;
                            B2_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 43:
                            B2_null[2] = chkNull.Checked;
                            B2_method[2] = lstMethod.SelectedIndex + 1;
                            B2_order[2] = lstOrder.SelectedIndex + 1;
                            B2_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 44:
                            B2_null[3] = chkNull.Checked;
                            B2_method[3] = lstMethod.SelectedIndex + 1;
                            B2_order[3] = lstOrder.SelectedIndex + 1;
                            B2_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 45:
                            B2_null[4] = chkNull.Checked;
                            B2_method[4] = lstMethod.SelectedIndex + 1;
                            B2_order[4] = lstOrder.SelectedIndex + 1;
                            B2_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 46:
                            B2_null[5] = chkNull.Checked;
                            B2_method[5] = lstMethod.SelectedIndex + 1;
                            B2_order[5] = lstOrder.SelectedIndex + 1;
                            B2_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                case 33:
                    switch (mnSelect2)
                    {
                        case 41:
                            B3_null[0] = chkNull.Checked;
                            B3_method[0] = lstMethod.SelectedIndex + 1;
                            B3_order[0] = lstOrder.SelectedIndex + 1;
                            B3_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 42:
                            B3_null[1] = chkNull.Checked;
                            B3_method[1] = lstMethod.SelectedIndex + 1;
                            B3_order[1] = lstOrder.SelectedIndex + 1;
                            B3_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 43:
                            B3_null[2] = chkNull.Checked;
                            B3_method[2] = lstMethod.SelectedIndex + 1;
                            B3_order[2] = lstOrder.SelectedIndex + 1;
                            B3_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 44:
                            B3_null[3] = chkNull.Checked;
                            B3_method[3] = lstMethod.SelectedIndex + 1;
                            B3_order[3] = lstOrder.SelectedIndex + 1;
                            B3_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 45:
                            B3_null[4] = chkNull.Checked;
                            B3_method[4] = lstMethod.SelectedIndex + 1;
                            B3_order[4] = lstOrder.SelectedIndex + 1;
                            B3_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 46:
                            B3_null[5] = chkNull.Checked;
                            B3_method[5] = lstMethod.SelectedIndex + 1;
                            B3_order[5] = lstOrder.SelectedIndex + 1;
                            B3_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                case 34:
                    switch (mnSelect2)
                    {
                        case 41:
                            A4_null[0] = chkNull.Checked;
                            A4_method[0] = lstMethod.SelectedIndex + 1;
                            A4_order[0] = lstOrder.SelectedIndex + 1;
                            A4_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 42:
                            A4_null[1] = chkNull.Checked;
                            A4_method[1] = lstMethod.SelectedIndex + 1;
                            A4_order[1] = lstOrder.SelectedIndex + 1;
                            A4_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 43:
                            A4_null[2] = chkNull.Checked;
                            A4_method[2] = lstMethod.SelectedIndex + 1;
                            A4_order[2] = lstOrder.SelectedIndex + 1;
                            A4_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 44:
                            A4_null[3] = chkNull.Checked;
                            A4_method[3] = lstMethod.SelectedIndex + 1;
                            A4_order[3] = lstOrder.SelectedIndex + 1;
                            A4_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 45:
                            A4_null[4] = chkNull.Checked;
                            A4_method[4] = lstMethod.SelectedIndex + 1;
                            A4_order[4] = lstOrder.SelectedIndex + 1;
                            A4_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 46:
                            A4_null[5] = chkNull.Checked;
                            A4_method[5] = lstMethod.SelectedIndex + 1;
                            A4_order[5] = lstOrder.SelectedIndex + 1;
                            A4_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                case 35:
                    switch (mnSelect2)
                    {
                       case 41:
                            A5_null[0] = chkNull.Checked;
                            A5_method[0] = lstMethod.SelectedIndex + 1;
                            A5_order[0] = lstOrder.SelectedIndex + 1;
                            A5_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 42:
                            A5_null[1] = chkNull.Checked;
                            A5_method[1] = lstMethod.SelectedIndex + 1;
                            A5_order[1] = lstOrder.SelectedIndex + 1;
                            A5_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 43:
                            A5_null[2] = chkNull.Checked;
                            A5_method[2] = lstMethod.SelectedIndex + 1;
                            A5_order[2] = lstOrder.SelectedIndex + 1;
                            A5_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 44:
                            A5_null[3] = chkNull.Checked;
                            A5_method[3] = lstMethod.SelectedIndex + 1;
                            A5_order[3] = lstOrder.SelectedIndex + 1;
                            A5_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 45:
                            A5_null[4] = chkNull.Checked;
                            A5_method[4] = lstMethod.SelectedIndex + 1;
                            A5_order[4] = lstOrder.SelectedIndex + 1;
                            A5_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 46:
                            A5_null[5] = chkNull.Checked;
                            A5_method[5] = lstMethod.SelectedIndex + 1;
                            A5_order[5] = lstOrder.SelectedIndex + 1;
                            A5_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }
                case 36:
                    switch (mnSelect2)
                    {
                        case 41:
                            A6_null[0] = chkNull.Checked;
                            A6_method[0] = lstMethod.SelectedIndex + 1;
                            A6_order[0] = lstOrder.SelectedIndex + 1;
                            A6_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 42:
                            A6_null[1] = chkNull.Checked;
                            A6_method[1] = lstMethod.SelectedIndex + 1;
                            A6_order[1] = lstOrder.SelectedIndex + 1;
                            A6_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 43:
                            A6_null[2] = chkNull.Checked;
                            A6_method[2] = lstMethod.SelectedIndex + 1;
                            A6_order[2] = lstOrder.SelectedIndex + 1;
                            A6_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 44:
                            A6_null[3] = chkNull.Checked;
                            A6_method[3] = lstMethod.SelectedIndex + 1;
                            A6_order[3] = lstOrder.SelectedIndex + 1;
                            A6_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 45:
                            A6_null[4] = chkNull.Checked;
                            A6_method[4] = lstMethod.SelectedIndex + 1;
                            A6_order[4] = lstOrder.SelectedIndex + 1;
                            A6_index[4] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 46:
                            A6_null[5] = chkNull.Checked;
                            A6_method[5] = lstMethod.SelectedIndex + 1;
                            A6_order[5] = lstOrder.SelectedIndex + 1;
                            A6_index[5] = Convert.ToInt32(lblIndex.Text);
                            break;
                    }


                //4
                case 41:
                    switch (mnSelect2)
                    {
                        case 31:
                            D1_null[0] = chkNull.Checked;
                            D1_method[0] = lstMethod.SelectedIndex + 1;
                            D1_order[0] = lstOrder.SelectedIndex + 1;
                            D1_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 32:
                            D1_null[1] = chkNull.Checked;
                            D1_method[1] = lstMethod.SelectedIndex + 1;
                            D1_order[1] = lstOrder.SelectedIndex + 1;
                            D1_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 53:
                            D1_null[2] = chkNull.Checked;
                            D1_method[2] = lstMethod.SelectedIndex + 1;
                            D1_order[2] = lstOrder.SelectedIndex + 1;
                            D1_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 54:
                            D1_null[3] = chkNull.Checked;
                            D1_method[3] = lstMethod.SelectedIndex + 1;
                            D1_order[3] = lstOrder.SelectedIndex + 1;
                            D1_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                         }
                case 42:
                    switch (mnSelect2)
                    {
                        case 51:
                            D2_null[0] = chkNull.Checked;
                            D2_method[0] = lstMethod.SelectedIndex + 1;
                            D2_order[0] = lstOrder.SelectedIndex + 1;
                            D2_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 52:
                            D2_null[1] = chkNull.Checked;
                            D2_method[1] = lstMethod.SelectedIndex + 1;
                            D2_order[1] = lstOrder.SelectedIndex + 1;
                            D2_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 53:
                            D2_null[2] = chkNull.Checked;
                            D2_method[2] = lstMethod.SelectedIndex + 1;
                            D2_order[2] = lstOrder.SelectedIndex + 1;
                            D2_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 54:
                            D2_null[3] = chkNull.Checked;
                            D2_method[3] = lstMethod.SelectedIndex + 1;
                            D2_order[3] = lstOrder.SelectedIndex + 1;
                            D2_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                              }
                case 43:
                    switch (mnSelect2)
                    {
                        case 51:
                            D3_null[0] = chkNull.Checked;
                            D3_method[0] = lstMethod.SelectedIndex + 1;
                            D3_order[0] = lstOrder.SelectedIndex + 1;
                            D3_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 52:
                            D3_null[1] = chkNull.Checked;
                            D3_method[1] = lstMethod.SelectedIndex + 1;
                            D3_order[1] = lstOrder.SelectedIndex + 1;
                            D3_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 53:
                            D3_null[2] = chkNull.Checked;
                            D3_method[2] = lstMethod.SelectedIndex + 1;
                            D3_order[2] = lstOrder.SelectedIndex + 1;
                            D3_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 54:
                            D3_null[3] = chkNull.Checked;
                            D3_method[3] = lstMethod.SelectedIndex + 1;
                            D3_order[3] = lstOrder.SelectedIndex + 1;
                            D3_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                          }
                case 44:
                    switch (mnSelect2)
                    {
                        case 51:
                            D4_null[0] = chkNull.Checked;
                            D4_method[0] = lstMethod.SelectedIndex + 1;
                            D4_order[0] = lstOrder.SelectedIndex + 1;
                            D4_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 52:
                            D4_null[1] = chkNull.Checked;
                            D4_method[1] = lstMethod.SelectedIndex + 1;
                            D4_order[1] = lstOrder.SelectedIndex + 1;
                            D4_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 53:
                            D4_null[2] = chkNull.Checked;
                            D4_method[2] = lstMethod.SelectedIndex + 1;
                            D4_order[2] = lstOrder.SelectedIndex + 1;
                            D4_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 54:
                            D4_null[3] = chkNull.Checked;
                            D4_method[3] = lstMethod.SelectedIndex + 1;
                            D4_order[3] = lstOrder.SelectedIndex + 1;
                            D4_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                          }
                case 45:
                    switch (mnSelect2)
                    {
                        case 51:
                            D5_null[0] = chkNull.Checked;
                            D5_method[0] = lstMethod.SelectedIndex + 1;
                            D5_order[0] = lstOrder.SelectedIndex + 1;
                            D5_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 52:
                            D5_null[1] = chkNull.Checked;
                            D5_method[1] = lstMethod.SelectedIndex + 1;
                            D5_order[1] = lstOrder.SelectedIndex + 1;
                            D5_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 53:
                            D5_null[2] = chkNull.Checked;
                            D5_method[2] = lstMethod.SelectedIndex + 1;
                            D5_order[2] = lstOrder.SelectedIndex + 1;
                            D5_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 54:
                            D5_null[3] = chkNull.Checked;
                            D5_method[3] = lstMethod.SelectedIndex + 1;
                            D5_order[3] = lstOrder.SelectedIndex + 1;
                            D5_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                            }
                case 46:
                    switch (mnSelect2)
                    {
                        case 51:
                            D6_null[0] = chkNull.Checked;
                            D6_method[0] = lstMethod.SelectedIndex + 1;
                            D6_order[0] = lstOrder.SelectedIndex + 1;
                            D6_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 52:
                            D6_null[1] = chkNull.Checked;
                            D6_method[1] = lstMethod.SelectedIndex + 1;
                            D6_order[1] = lstOrder.SelectedIndex + 1;
                            D6_index[1] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 53:
                            D6_null[2] = chkNull.Checked;
                            D6_method[2] = lstMethod.SelectedIndex + 1;
                            D6_order[2] = lstOrder.SelectedIndex + 1;
                            D6_index[2] = Convert.ToInt32(lblIndex.Text);
                            break;
                        case 54:
                            D6_null[3] = chkNull.Checked;
                            D6_method[3] = lstMethod.SelectedIndex + 1;
                            D6_order[3] = lstOrder.SelectedIndex + 1;
                            D6_index[3] = Convert.ToInt32(lblIndex.Text);
                            break;
                            }


                //5
                case 51:
                    switch (mnSelect2)
                    {
                        case 51:
                            E1_null[0] = chkNull.Checked;
                            E1_method[0] = lstMethod.SelectedIndex + 1;
                            E1_order[0] = lstOrder.SelectedIndex + 1;
                            E1_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                      }
                case 52:
                    switch (mnSelect2)
                    {
                        case 52:
                            E2_null[0] = chkNull.Checked;
                            E2_method[0] = lstMethod.SelectedIndex + 1;
                            E2_order[0] = lstOrder.SelectedIndex + 1;
                            E2_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                        }
                case 53:
                    switch (mnSelect2)
                    {
                        case 53:
                            E3_null[0] = chkNull.Checked;
                            E3_method[0] = lstMethod.SelectedIndex + 1;
                            E3_order[0] = lstOrder.SelectedIndex + 1;
                            E3_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                            }
                default:
                    switch (mnSelect2)
                    {
                        case 54:
                            E4_null[0] = chkNull.Checked;
                            E4_method[0] = lstMethod.SelectedIndex + 1;
                            E4_order[0] = lstOrder.SelectedIndex + 1;
                            E4_index[0] = Convert.ToInt32(lblIndex.Text);
                            break;
                               }
             }
        }
        private void fReset()
        {
            mbSelectFirst = true;
            mnSelect1 = 11;
            mnSelect2 = 11;

            fUpdateDisplay();
        }

        private String fCell(int nCell)
        {
            switch (nCell)
            {
                case 11:
                    return "T1";
                case 12:
                    return "T2";
                case 13:
                    return "T3";
                case 14:
                    return "T4";
                case 15:
                    return "T5";
                case 16:
                    return "T6";
                case 17:
                    return "T7";
                case 18:
                    return "T8";
                case 21:
                    return "A1";
                case 22:
                    return "A2";
                case 23:
                    return "A3";
                case 24:
                    return "A4";
                case 25:
                    return "A5";
                case 26:
                    return "A6";
                case 31:
                    return "B1";
                case 32:
                    return "B2";
                case 33:
                    return "B3";
                case 34:
                    return "B4";
                case 35:
                    return "B5";
                case 36:
                    return "B6";
                case 41:
                    return "C1";
                case 42:
                    return "C2";
                case 43:
                    return "C3";
                case 44:
                    return "C4";
                case 45:
                    return "C5";
                case 46:
                    return "C6";
                case 51:
                    return "E1";
                case 52:
                    return "E2";
                case 53:
                    return "E3";
                default:
                    return "E4";

            }
        }
        private void fUpdateDisplay()
        {
            String sText1 = fCell(mnSelect1);
            String sText2 = fCell(mnSelect2);
            String sText = sText1 + " (" + sText2 + ")";

            lblItem.Text = sText;
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 11;
            }
            else
            {
                mnSelect2 = 11;
            }
            fUpdateDisplay();
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 12;
            }
            else
            {
                mnSelect2 = 12;
            }
            fUpdateDisplay();

        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 13;
            }
            else
            { 
                mnSelect2 = 13;
            }
            fUpdateDisplay();

        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 14;
            }
            else
            {
                mnSelect2 = 14;
            }
            fUpdateDisplay();

        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 15;
            }
            else
            {
                mnSelect2 = 15;
            }
            fUpdateDisplay();

        }

        private void btnT6_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 16;
            }
            else
            {
                mnSelect2 = 16;
            }
            fUpdateDisplay();

        }

        private void btnT7_Click(object sender, EventArgs e)
        {

            if (mbSelectFirst)
            {
                mnSelect1 = 17;
            }
            else
            {
                mnSelect2 = 17;
            }
            fUpdateDisplay();
        }



        private void btnSelect1_Click(object sender, EventArgs e)
        {
            mbSelectFirst = true;

        }

        private void btnT8_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 18;
            }
            else
            {
                mnSelect2 = 18;
            }
            fUpdateDisplay();

        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 21;
            }
            else
            {
                mnSelect2 = 21;
            }
            fUpdateDisplay();

        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 22;
            }
            else
            {
                mnSelect2 = 22;
            }
            fUpdateDisplay();

        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 23;
            }
            else
            {
                mnSelect2 = 23;
            }
            fUpdateDisplay();

        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 24;
            }
            else
            {
                mnSelect2 = 24;
            }
            fUpdateDisplay();

        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 25;
            }
            else
            {
                mnSelect2 = 25;
            }
            fUpdateDisplay();

        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 26;
            }
            else
            {
                mnSelect2 = 26;
            }
            fUpdateDisplay();

        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 31;
            }
            else
            {
                mnSelect2 = 31;
            }
            fUpdateDisplay();

        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 32;
            }
            else
            {
                mnSelect2 = 32;
            }
            fUpdateDisplay();

        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 33;
            }
            else
            {
                mnSelect2 = 33;
            }
            fUpdateDisplay();

        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 34;
            }
            else
            {
                mnSelect2 = 34;
            }
            fUpdateDisplay();

        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 35;
            }
            else
            {
                mnSelect2 = 35;
            }
            fUpdateDisplay();

        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 36;
            }
            else
            {
                mnSelect2 = 36;
            }
            fUpdateDisplay();

        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 41;
            }
            else
            {
                mnSelect2 = 41;
            }
            fUpdateDisplay();

        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 42;
            }
            else
            {
                mnSelect2 = 42;
            }
            fUpdateDisplay();

        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 43;
            }
            else
            {
                mnSelect2 = 43;
            }
            fUpdateDisplay();

        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 44;
            }
            else
            {
                mnSelect2 = 44;
            }
            fUpdateDisplay();

        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 45;
            }
            else
            {
                mnSelect2 = 45;
            }
            fUpdateDisplay();

        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 46;
            }
            else
            {
                mnSelect2 = 46;
            }
            fUpdateDisplay();

        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 51;
            }
            else
            {
                mnSelect2 = 51;
            }
            fUpdateDisplay();

        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 52;
            }
            else
            {
                mnSelect2 = 52;
            }
            fUpdateDisplay();

        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 53;
            }
            else
            {
                mnSelect2 = 53;
            }
            fUpdateDisplay();

        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            if (mbSelectFirst)
            {
                mnSelect1 = 54;
            }
            else
            {
                mnSelect2 = 54;
            }
            fUpdateDisplay();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave();
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            {
                mbSelectFirst = false;
            }
        }
    }
}
