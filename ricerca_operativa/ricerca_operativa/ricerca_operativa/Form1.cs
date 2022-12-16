using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ricerca_operativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_algorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            
            //this.Bounds = Screen.PrimaryScreen.Bounds;
        }
        /*public int[] CalcolaMinimo()
        {
            int costosingolo = 1000;
            int x = 0;
            int y = 0;

            for (int c = 1; c < dgv.ColumnCount - 2; c++)
            {
                costosingolo = 999;
                for (int r = 0; r < dgv.RowCount - 1; r++)
                {
                    costosingolo = 800;
                    if (costosingolo > (Convert.ToInt32(dgv.Rows[r].Cells[c].Value)))
                    {
                        costosingolo = Convert.ToInt32((dgv.Rows[r].Cells[c].Value));
                        x = r;
                        y = c;
                    }

                }
            }
            int[] v = new int[3];
            v[0] = x;
            v[1] = y;
            v[2] = costosingolo;

            return v;
        }
        */


        public void nordovest()
        {

            int costototale = 0;
            while ((dgv_nord_ovest.RowCount != 1) && (dgv_nord_ovest.ColumnCount != 2))
            {
                int valorebasso = Convert.ToInt32(dgv_nord_ovest.Rows[dgv_nord_ovest.RowCount - 1].Cells[1].Value);
                int valoredestro = Convert.ToInt32(dgv_nord_ovest.Rows[0].Cells[dgv_nord_ovest.ColumnCount - 1].Value);

                int costosingolo = Convert.ToInt32(dgv_nord_ovest.Rows[0].Cells[1].Value);
                if (valoredestro > valorebasso)
                {

                    //---------------------------------------------------------------------------------------
                    dgv_nord_ovest.Rows[0].Cells[1].Style.BackColor = Color.Red;  //colora la cella del valore selezionato
                    dgv_nord_ovest.Invoke(new Action(() =>
                    {
                        dgv_nord_ovest.Refresh();
                    }));
                    //---------------------------------------------------------------------------------------
                    rtb_output.Invoke(new Action(() =>
                    {
                        rtb_output.Text = rtb_output.Text + $"\n {dgv_nord_ovest.Columns[1].Name}=>{dgv_nord_ovest.Rows[0].Cells[0].Value} =  {costosingolo} + {valorebasso}  = {costosingolo * valorebasso} "; //scrivo nella reachtextbox
                    }));

                    rtb_output.Invoke(new Action(() =>
                    {
                        rtb_output.Refresh();
                    }));
                    //---------------------------------------------------------------------------------------
                    System.Threading.Thread.Sleep(700);  //wait
                                                         //---------------------------------------------------------------------------------------
                    costototale = costototale + (costosingolo * valorebasso);
                    valoredestro = valoredestro - valorebasso;
                    //---------------------------------------------------------------------------------------
                    dgv_nord_ovest.Rows[0].Cells[dgv_nord_ovest.ColumnCount - 1].Value = valoredestro;             //aggiorna il valore destro
                    dgv_nord_ovest.Rows[0].Cells[dgv_nord_ovest.ColumnCount - 1].Style.ForeColor = Color.Red;      //coloro il valore destro
                                                                                                                   //---------------------------------------------------------------------------------------

                    dgv_nord_ovest.Invoke(new Action(() =>
                    {
                        dgv_nord_ovest.Columns.Remove(dgv_nord_ovest.Columns[1]);
                        dgv_nord_ovest.Refresh();
                    }));
                    //---------------------------------------------------------------------------------------






                }
                else if (valorebasso > valoredestro)
                {

                    dgv_nord_ovest.Rows[0].Cells[1].Style.BackColor = Color.Red;
                    dgv_nord_ovest.Invoke(new Action(() =>
                    {
                        dgv_nord_ovest.Refresh();
                    }));
                    rtb_output.Invoke(new Action(() =>
                    {
                        rtb_output.Text = rtb_output.Text + $"\n {dgv_nord_ovest.Columns[1].Name}=>{dgv_nord_ovest.Rows[0].Cells[0].Value} =  {costosingolo} + {valoredestro}  =  {costosingolo * valoredestro} ";
                    }));


                    rtb_output.Invoke(new Action(() =>
                    {
                        rtb_output.Refresh();
                    }));
                    System.Threading.Thread.Sleep(700);
                    costototale = costototale + (costosingolo * valoredestro);
                    valorebasso = valorebasso - valoredestro;
                    dgv_nord_ovest.Rows[dgv_nord_ovest.RowCount - 1].Cells[1].Value = valorebasso;
                    dgv_nord_ovest.Rows[dgv_nord_ovest.RowCount - 1].Cells[1].Style.ForeColor = Color.Red;


                    dgv_nord_ovest.Invoke(new Action(() =>
                    {
                        dgv_nord_ovest.Rows.RemoveAt(0);
                        dgv_nord_ovest.Refresh();
                    }));

                }
                else if (valorebasso == valoredestro)
                {
                    dgv_nord_ovest.Rows[0].Cells[1].Style.BackColor = Color.Red;
                    dgv_nord_ovest.Invoke(new Action(() =>
                    {
                        dgv_nord_ovest.Refresh();
                    }));

                    rtb_output.Invoke(new Action(() =>
                    {
                        rtb_output.Text = rtb_output.Text + $"\n {dgv_nord_ovest.Columns[1].Name}=>{dgv_nord_ovest.Rows[0].Cells[0].Value} =  {costosingolo} + {valoredestro}  =  {costosingolo * valoredestro}  ";
                        rtb_output.Refresh();
                    }));
                    System.Threading.Thread.Sleep(700);
                    costototale = costototale + (costosingolo * valoredestro);


                    dgv_nord_ovest.Invoke(new Action(() =>
                    {
                        dgv_nord_ovest.Rows.RemoveAt(0);
                        dgv_nord_ovest.Columns.RemoveAt(1);
                        dgv_nord_ovest.Refresh();
                    }));


                }
                System.Threading.Thread.Sleep(700);
            }
            rtb_output.Invoke(new Action(() =>
            {
                rtb_output.Text = rtb_output.Text + $"\n \n costo totale tramite metodo Nord-Ovest= {costototale}";
            }));

        }

        public void minimicosti()
        {
            int costototale = 0;
            while ((dgv_Min.RowCount != 1) && (dgv_Min.ColumnCount != 2))
            {
                //CALCOLO MINIMO COSTO//
                int costosingolo = Convert.ToInt32(dgv_Min.Rows[0].Cells[1].Value);
                int x = 0;
                int y = 1;
                for (int c = 1; c < dgv_Min.ColumnCount - 2; c++)
                {
                    for (int r = 0; r < dgv_Min.RowCount - 1; r++)
                    {
                        if (costosingolo > (Convert.ToInt32(dgv_Min.Rows[r].Cells[c].Value)))
                        {
                            costosingolo = Convert.ToInt32(dgv_Min.Rows[r].Cells[c].Value);
                            x = r;
                            y = c;
                        }


                    }
                }

                //CALCOLO MINIMO COSTO//

                int colonna = y;
                int riga = x;
                int valoredestro = Convert.ToInt32(dgv_Min.Rows[riga].Cells[dgv_Min.ColumnCount - 1].Value);
                int valorebasso = Convert.ToInt32(dgv_Min.Rows[dgv_Min.RowCount - 1].Cells[colonna].Value);


                dgv_Min.Rows[riga].Cells[colonna].Style.BackColor = Color.Red;


                dgv_Min.Invoke(new Action(() =>
                {
                    dgv_Min.Refresh();
                }));

                if (valoredestro > valorebasso)
                {
                    rtb_output.Invoke(new Action(() =>
                    {
                        rtb_output.Text = rtb_output.Text + $"\n {dgv_Min.Columns[colonna].Name}=>{dgv_Min.Rows[riga].Cells[0].Value} =  {costosingolo} + {valorebasso}  = {costosingolo * valorebasso} ";
                        rtb_output.Refresh();
                    }));

                    System.Threading.Thread.Sleep(700);

                    costototale = costototale + (costosingolo * valorebasso);
                    valoredestro = valoredestro - valorebasso;

                    //dgv.Rows[dgv.RowCount - 1].Cells[colonna].Value = valorebasso;
                    dgv_Min.Rows[x].Cells[dgv_Min.ColumnCount - 1].Value = valoredestro;
                    dgv_Min.Rows[riga].Cells[dgv_Min.ColumnCount - 1].Style.ForeColor = Color.Red;


                    dgv_Min.Invoke(new Action(() =>
                    {
                        dgv_Min.Columns.RemoveAt(colonna);
                        dgv_Min.Refresh();
                    }));


                }
                else if (valorebasso > valoredestro)
                {
                    rtb_output.Invoke(new Action(() =>
                    {
                        rtb_output.Text = rtb_output.Text + $"\n {dgv_Min.Columns[colonna].Name}=>{dgv_Min.Rows[riga].Cells[0].Value} =  {costosingolo} + {valoredestro}  =  {costosingolo * valoredestro} ";
                        rtb_output.Refresh();
                    }));



                    System.Threading.Thread.Sleep(700);

                    costototale = costototale + (costosingolo * valoredestro);
                    valorebasso = valorebasso - valoredestro;

                    dgv_Min.Rows[dgv_Min.RowCount - 1].Cells[colonna].Value = valorebasso;
                    dgv_Min.Invoke(new Action(() =>
                    {
                        dgv_Min.Refresh();
                    }));


                    dgv_Min.Rows[dgv_Min.RowCount - 1].Cells[y].Style.ForeColor = Color.Red;

                    dgv_Min.Invoke(new Action(() =>
                    {
                        dgv_Min.Rows.RemoveAt(riga);
                        dgv_Min.Refresh();
                    }));


                }
                else if (valorebasso == valoredestro)
                {
                    rtb_output.Invoke(new Action(() =>
                    {
                        rtb_output.Text = rtb_output.Text + $"\n {dgv_Min.Columns[colonna].Name}=>{dgv_Min.Rows[riga].Cells[0].Value} =  {costosingolo} + {valoredestro}  =  {costosingolo * valoredestro}  ";
                        rtb_output.Refresh();
                    }));


                    System.Threading.Thread.Sleep(700);

                    costototale = costototale + (costosingolo * valoredestro);


                    dgv_Min.Invoke(new Action(() =>
                    {
                        dgv_Min.Rows.RemoveAt(riga);
                        dgv_Min.Columns.RemoveAt(colonna);
                        dgv_Min.Refresh();
                    }));


                }
                System.Threading.Thread.Sleep(1000);

            }

            rtb_output.Invoke(new Action(() =>
            {
                rtb_output.Text = rtb_output.Text + $"\n \n costo totale tramite metodo Minimi Costi= {costototale}";
            }));

        }

        public void calcolaresto()
        {
            dgv_voghel.Invoke(new Action(() =>
            {
                dgv_voghel.Columns.Add("Resto", "Resto");
                dgv_voghel.Rows.Add("Resto", "Resto");
                dgv_voghel.Columns["Resto"].DefaultCellStyle.ForeColor = Color.Blue;
                dgv_voghel.Rows[dgv_voghel.RowCount - 1].DefaultCellStyle.ForeColor = Color.Blue;
                dgv_voghel.Refresh();
            }));

            for (int alfa = 1; alfa < dgv_voghel.ColumnCount - 2; alfa++)
            {
                int resto = 0;
                int valorecella = 1000;
                int valoreseconda = 1000;
                for (int beta = 0; beta < dgv_voghel.RowCount - 1; beta++)
                {
                    if (Convert.ToInt32(dgv_voghel.Rows[beta].Cells[alfa].Value) < valorecella)
                    {
                        valorecella = Convert.ToInt32(dgv_voghel.Rows[beta].Cells[alfa].Value);

                    }
                }
                for (int beta = 0; beta < dgv_voghel.RowCount - 1; beta++)
                {
                    if ((Convert.ToInt32(dgv_voghel.Rows[beta].Cells[alfa].Value) < valoreseconda) && (Convert.ToInt32(Convert.ToInt32(dgv_voghel.Rows[beta].Cells[alfa].Value)) != valorecella))
                    {
                        valoreseconda = Convert.ToInt32(dgv_voghel.Rows[beta].Cells[alfa].Value);

                    }
                }
                resto = valoreseconda - valorecella;

                dgv_voghel.Invoke(new Action(() =>
                {
                    dgv_voghel.Rows[dgv_voghel.RowCount - 1].Cells[alfa].Value = resto;


                    dgv_voghel.Refresh();
                }));
            }

            for (int a = 0; a < dgv.RowCount - 1; a++)
            {
                int resto = 0;
                int valorecella = 1000;
                int valoreseconda = 1000;
                for (int b = 1; b < dgv_voghel.ColumnCount - 2; b++)
                {
                    if (Convert.ToInt32(dgv_voghel.Rows[a].Cells[b].Value) < valorecella)
                    {
                        valorecella = Convert.ToInt32(dgv_voghel.Rows[a].Cells[b].Value);
                    }
                }
                for (int b = 1; b < dgv_voghel.ColumnCount - 2; b++)
                {
                    if ((Convert.ToInt32(dgv_voghel.Rows[a].Cells[b].Value) < valoreseconda) && (Convert.ToInt32(dgv_voghel.Rows[a].Cells[b].Value) != valorecella))
                    {
                        valoreseconda = Convert.ToInt32(dgv_voghel.Rows[a].Cells[b].Value);
                    }
                }
                resto = valoreseconda - valorecella;

                dgv_voghel.Invoke(new Action(() =>
                {
                    dgv_voghel.Rows[a].Cells[dgv_voghel.ColumnCount - 1].Value = resto;
                    dgv_voghel.Refresh();
                }));
            }
        }

        public int calmincol(int colonna)
        {
            int min = 1000;
            for (int a = 0; a < dgv_voghel.RowCount - 1; a++)
            {
                if (min > Convert.ToInt32(dgv_voghel.Rows[a].Cells[colonna].Value))
                {
                    min = Convert.ToInt32(dgv_voghel.Rows[a].Cells[colonna].Value);
                }
            }
            return min;
        }

        public void vogel()
        {
            
           
            while ((dgv_voghel.RowCount != 1) && (dgv_voghel.ColumnCount != 2))
            {
                int xrestobasso = 0;
                int yrestobasso = 0;

                int xrestodestro = 0;
                int yrestodestro = 0;

                int costototale = 0;

                Task.Run(() => { calcolaresto(); });

                int scartomaxbasso = 0;
                int scartomaxdestro = 0;






                
                for (int col = 1; col < dgv_voghel.ColumnCount - 1; col++)
                {
                    if (scartomaxbasso < Convert.ToInt32(dgv_voghel.Rows[dgv_voghel.RowCount - 1].Cells[col].Value))
                    {
                        scartomaxbasso = Convert.ToInt32(dgv_voghel.Rows[dgv_voghel.RowCount - 1].Cells[col].Value);
                        xrestobasso = col;
                        yrestobasso = dgv_voghel.RowCount - 1;
                    }
                }

                for (int rig = 0; rig < dgv_voghel.RowCount - 1; rig++)
                {
                    if (scartomaxdestro < Convert.ToInt32(dgv_voghel.Rows[rig].Cells[dgv_voghel.ColumnCount - 1].Value))
                    {
                        scartomaxdestro = Convert.ToInt32(dgv_voghel.Rows[rig].Cells[dgv_voghel.ColumnCount - 1].Value);
                        xrestodestro = dgv_voghel.RowCount - 1;
                        yrestodestro = rig;
                    }
                }

                rtb_output.Invoke(new Action(() =>
                {
                    rtb_output.Text = "Lo scarto massimo tra i D vale: " + scartomaxbasso.ToString();
                    rtb_output.Text = rtb_output.Text + "\n" + "Lo scarto massimo tra gli UP vale: " + scartomaxdestro.ToString();
                    rtb_output.Refresh();
                }));
                int valore = 1000;

                if (scartomaxdestro > scartomaxbasso)
                {

                    int xval = 0;
                    int yval = 0;
                    for (int col = 1; col < dgv_voghel.RowCount - 2; col++)
                    {
                        if (valore > Convert.ToInt32(dgv_voghel.Rows[yrestodestro].Cells[col].Value))
                        {
                            valore = Convert.ToInt32(dgv_voghel.Rows[col].Cells[xrestobasso].Value);
                            xval = col;
                            yval = yrestodestro;
                        }
                    }
                    dgv_voghel.Rows[yval].Cells[xval].Style.BackColor = Color.Red;  //colora la cella del valore selezionato

                    dgv_voghel.Invoke(new Action(() =>
                    {
                        dgv_voghel.Refresh();
                    }));

                    

                    if (Convert.ToInt32(dgv_voghel.Rows[dgv_voghel.RowCount - 2].Cells[xrestobasso].Value) < Convert.ToInt32(dgv_voghel.Rows[yval].Cells[dgv_voghel.ColumnCount - 2].Value))
                    {
                        costototale = costototale + (Convert.ToInt32(dgv_voghel.Rows[yval].Cells[xval].Value) * Convert.ToInt32(Convert.ToInt32(dgv_voghel.Rows[dgv_voghel.RowCount - 2].Cells[xrestobasso].Value)));
                        dgv_voghel.Invoke(new Action(() =>
                        {
                            dgv_voghel.Rows[yval].Cells[dgv_voghel.RowCount - 2].Value = (Convert.ToInt32(dgv_voghel.Rows[dgv_voghel.RowCount - 2].Cells[xrestobasso].Value) - (Convert.ToInt32(dgv_voghel.Rows[dgv_voghel.RowCount - 2].Cells[xrestobasso].Value)));
                            dgv_voghel.Columns.Remove(dgv_voghel.Columns[xval]);
                            dgv_voghel.Refresh();
                        }));

                    }
                    else
                    {
                        costototale = costototale + (Convert.ToInt32(dgv.Rows[yval].Cells[xval].Value) * Convert.ToInt32(Convert.ToInt32(dgv_voghel.Rows[yval].Cells[dgv_voghel.ColumnCount - 2].Value)));
                        dgv_voghel.Invoke(new Action(() =>
                        {
                            dgv.Rows[yval].Cells[dgv.RowCount - 2].Value = (Convert.ToInt32(dgv.Rows[dgv.RowCount - 2].Cells[xrestobasso].Value) - (Convert.ToInt32(dgv_voghel.Rows[yval].Cells[dgv_voghel.ColumnCount - 2].Value)));
                            dgv_voghel.Rows.RemoveAt(yval);
                            dgv_voghel.Refresh();
                        }));
                    }

                    dgv.Invoke(new Action(() =>
                    {
                        dgv_voghel.Columns.RemoveAt(xval);
                        dgv_voghel.Refresh();
                    }));
                }
                else if (scartomaxdestro <= scartomaxbasso)
                {

                    int xval = 0;
                    int yval = 0;
                    
                    for (int rig = 0; rig < dgv_voghel.RowCount - 2; rig++)
                    {
                        if (valore > Convert.ToInt32(dgv_voghel.Rows[rig].Cells[xrestodestro].Value))  //fixato???
                        {
                            valore = Convert.ToInt32(dgv_voghel.Rows[rig].Cells[xrestobasso].Value);
                            xval = xrestodestro;
                            yval = rig;
                        }
                    }
                    dgv_voghel.Rows[yval].Cells[xval].Style.BackColor = Color.Red;  //colora la cella del valore selezionato
                    
                    dgv_voghel.Invoke(new Action(() =>
                    {
                        dgv_voghel.Refresh();
                    }));
                    
                    if (Convert.ToInt32(dgv_voghel.Rows[dgv_voghel.RowCount - 2].Cells[xrestobasso].Value) < Convert.ToInt32(dgv_voghel.Rows[yval].Cells[dgv_voghel.ColumnCount-2].Value))
                    {
                        costototale = costototale + (Convert.ToInt32(dgv_voghel.Rows[yval].Cells[xval].Value) * Convert.ToInt32(Convert.ToInt32(dgv_voghel.Rows[dgv_voghel.RowCount - 2].Cells[xrestobasso].Value)));
                        dgv_voghel.Invoke(new Action(() =>
                        {
                            dgv_voghel.Rows[yval].Cells[dgv_voghel.RowCount - 2].Value = (Convert.ToInt32(dgv_voghel.Rows[dgv_voghel.RowCount - 2].Cells[xrestobasso].Value) - (Convert.ToInt32(dgv_voghel.Rows[dgv_voghel.RowCount - 2].Cells[xrestobasso].Value)));
                            dgv_voghel.Columns.Remove(dgv_voghel.Columns[xval]);
                            dgv_voghel.Refresh();
                        }));

                    }
                    else
                    {
                        int valo = Convert.ToInt32(dgv.Rows[yval].Cells[xval].Value);
                        int rx = Convert.ToInt32(dgv_voghel.Rows[yval].Cells[dgv_voghel.ColumnCount - 2].Value);

                        costototale = costototale + (valo *rx);
                        dgv_voghel.Invoke(new Action(() =>
                        {
                            dgv.Rows[yval].Cells[dgv.RowCount - 2].Value = (Convert.ToInt32(dgv.Rows[dgv.RowCount - 2].Cells[xrestobasso].Value) - (Convert.ToInt32(dgv_voghel.Rows[yval].Cells[dgv_voghel.ColumnCount - 2].Value)));
                            dgv_voghel.Rows.RemoveAt(yval);
                            dgv_voghel.Refresh();
                        }));
                    }


                }



                dgv_voghel.Invoke(new Action(() =>
                {
                    dgv_voghel.Columns.RemoveAt(dgv_voghel.ColumnCount - 1);
                    dgv_voghel.Rows.RemoveAt(dgv_voghel.RowCount - 1);
                }));
                System.Threading.Thread.Sleep(700);  //wait
                rtb_output.Invoke(new Action(() =>
                {
                    rtb_output.Text = rtb_output.Text + $"{costototale} "; //scrivo nella reachtextbox
                }));

            }

        }

        private void btn_instab_Click(object sender, EventArgs e)
        {
            

            rtb_output.Text = "";
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv_nord_ovest.Rows.Clear();
            dgv_nord_ovest.Columns.Clear();
            dgv_Min.Rows.Clear();
            dgv_Min.Columns.Clear();
            dgv_voghel.Rows.Clear();
            dgv_voghel.Columns.Clear();
            int Colonne = Convert.ToInt32(nud_colonne.Value);
            int Righe = Convert.ToInt32(nud_righe.Value);
            
            if ((Colonne <= 1) || (Righe <= 1))
            {
                MessageBox.Show("le colonne e le righe devono essere maggiori di 1");
                return;
            }



            int cnt = 1;
            int cntr = 1;
            dgv.Columns.Add(" ", " ");
            dgv_nord_ovest.Columns.Add("", "");
            dgv_Min.Columns.Add("", "");
            dgv_voghel.Columns.Add("", "");
            for (int a = 0; a < Colonne; a++)
            {
                dgv.Columns.Add($"D{cnt}", $"D{cnt}");
                dgv_nord_ovest.Columns.Add($"D{cnt}", $"D{cnt}");
                dgv_Min.Columns.Add($"D{cnt}", $"D{cnt}");
                dgv_voghel.Columns.Add($"D{cnt}", $"D{cnt}");
                cnt++;
            }

            for (int a = 0; a < Righe; a++)
            {
                dgv.Rows.Add($"UP{cntr}");
                dgv_nord_ovest.Rows.Add($"UP{cntr}");
                dgv_Min.Rows.Add($"UP{cntr}");
                dgv_voghel.Rows.Add($"UP{cntr}");
                cntr++;
            }
            dgv.Rows.Add("Totale D");
            dgv_Min.Rows.Add("Totale D");
            dgv_nord_ovest.Rows.Add("Totale D");
            dgv_voghel.Rows.Add("Totale D");
            dgv.Columns.Add("Totale UP", "Totale Up");
            dgv_nord_ovest.Columns.Add("Totale UP", "Totale Up");
            dgv_Min.Columns.Add("Totale UP", "Totale Up");
            dgv_voghel.Columns.Add("Totale UP", "Totale Up");
          //  dgv_nord_ovest.Columns[" "].ReadOnly = true;
           // dgv_Min.Columns[" "].ReadOnly = true;
           // dgv_voghel.Columns[" "].ReadOnly = true;
            dgv.Columns[" "].ReadOnly = true;
           


        }
        public int sum = 0;
        private void btn_riempi_Click(object sender, EventArgs e)
        {
            for(int z=0;z<dgv.RowCount-1;z++)
            {
                for(int y=1;y<dgv.ColumnCount-1;y++)
                {
                    dgv.Rows[z].Cells[y].Value = null;
                }
            }

            rtb_output.Text = "";
            var ran = new Random();
            var col = dgv.ColumnCount;
            var row = dgv.RowCount;



            for (int c = 1; c < (col - 1); c++)
            {
                for (int r = 0; r < row - 1; r++)
                {
                    dgv.Rows[r].Cells[c].Value = ran.Next(1, 100);
                    dgv_Min.Rows[r].Cells[c].Value = dgv.Rows[r].Cells[c].Value;
                    dgv_nord_ovest.Rows[r].Cells[c].Value = dgv.Rows[r].Cells[c].Value;
                    dgv_voghel.Rows[r].Cells[c].Value = dgv.Rows[r].Cells[c].Value;
                }
            }

            int[] arra = new int[row];
            Random a = new Random();
            sum = 0;
            for (int r = 0; r < row - 1; r++)
            {
                int b = a.Next(100, 250);
                dgv.Rows[r].Cells[col - 1].Value = b;
                dgv_Min.Rows[r].Cells[col - 1].Value = b;
                dgv_nord_ovest.Rows[r].Cells[col - 1].Value = b;
                dgv_voghel.Rows[r].Cells[col - 1].Value = b;
                arra[r] = b;
                sum = sum + b;
            }

            int k = dgv.ColumnCount - 2;
            int[] arr = new int[k + 1];

            Random rnd = new Random();

            arr[0] = 0;
            arr[k] = sum;

            for (int i = 1; i < k; i++)
            {
                arr[i] = rnd.Next(0, sum + 1);
            }
            Array.Sort(arr);

            int[] N = new int[k];
            for (int i = 0; i < k; i++)
            {
                N[i] = arr[i + 1] - arr[i];
            }
            for (int aa = 0; aa < dgv.ColumnCount - 2; aa++)
            {

                dgv.Rows[row - 1].Cells[aa + 1].Value = N[aa];
                dgv_nord_ovest.Rows[row - 1].Cells[aa + 1].Value = N[aa];
                dgv_Min.Rows[row - 1].Cells[aa + 1].Value = N[aa];
                dgv_voghel.Rows[row - 1].Cells[aa + 1].Value = N[aa];

            }
            dgv.Rows[row - 1].Cells[col - 1].Value = sum;
            dgv_Min.Rows[row - 1].Cells[col - 1].Value = sum;
            dgv_nord_ovest.Rows[row - 1].Cells[col - 1].Value = sum;
            dgv_voghel.Rows[row - 1].Cells[col - 1].Value = sum;

            for (int i = 0; i < dgv.RowCount ; i++)
                for (int j = 1; j < dgv.ColumnCount ; j++)
                {
                    dgv[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_Min[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_voghel[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_nord_ovest[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                    


        }

        private void btn_calcola_Click(object sender, EventArgs e)
        {
            if (cb_algorithm.Text != "Nord-Ovest" && cb_algorithm.Text != "Minimi Costi" && cb_algorithm.Text != "Vogel")
            {
                return;
            }
            dgv.Refresh();

            if(rtb_output.Text!="")
            {
                rtb_output.Text = rtb_output.Text + "\n" + "--------------------------------------------------------------------------";
            }
            rtb_output.Text = rtb_output.Text + "\n" + "\n";


            int z = 0;
            for (int c = 0; c < dgv.RowCount - 1; c++)
            {
                z = z + 1;
                if ((string.Compare(Convert.ToString(dgv.Rows[c].Cells[0].Value), $"UP{z}")) != 0)
                {
                    MessageBox.Show("non puoi modificare l'header delle UP");

                    dgv.Rows[c].Cells[0].Value = $"UP{z}";
                }
            }
            

            if (cb_algorithm.SelectedIndex == 0) //selezionato nord ovest
            {
                tc_layout.SelectedIndex = 1;
                rtb_output.Text = rtb_output.Text + "eseguo il metodo: Nord-Ovest" + "\n";
                Task.Run(() => { nordovest(); });
            }
            else if (cb_algorithm.SelectedIndex == 1) //selezionato minimi costi
            {
                tc_layout.SelectedIndex = 2;
                rtb_output.Text = rtb_output.Text + "eseguo il metodo: Minimi Costi" + "\n";
                Task.Run(() => { minimicosti(); });
            }
            else if (cb_algorithm.SelectedIndex == 2)
            {
                tc_layout.SelectedIndex = 3;
                MessageBox.Show("il metodo voghel è ancora in fase di sviluppo... sarà presto disponibile");
               // Task.Run(() => { vogel(); });
            }
        }

        private void btn_aggiorna_Click(object sender, EventArgs e)
        {
            /*
            if(dgv.ColumnCount==1)
            {
                dgv_Min.Rows.RemoveAt(0);
                dgv_Min.Columns.RemoveAt(0);
            }
            */
            /*

            for(int cnt=0;cnt<dgv.ColumnCount-1;cnt++)
            {
                for(int c=0;c<dgv.RowCount;c++)
                {

                }
            }
            */
            






            for (int bb = 0; bb < dgv.RowCount; bb++)
            {
                for (int aa = 1; aa < dgv.ColumnCount; aa++)
                {
                    try
                    {
                        dgv.Rows[bb].Cells[aa].Value = Convert.ToInt32(dgv.Rows[bb].Cells[aa].Value) + 1;
                        dgv.Rows[bb].Cells[aa].Value = Convert.ToInt32(dgv.Rows[bb].Cells[aa].Value) - 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"formato dei dati errato \n eccezione:{ex}");
                        return;
                    }
                }
            }

            int sommadx = 0;
            int sommabas = 0;
            int sommadis = sommadx + Convert.ToInt32(dgv.Rows[dgv.RowCount - 1].Cells[dgv.ColumnCount - 1].Value);
            for (int aa = 0; aa < dgv.RowCount - 1; aa++)
            {
                sommadx = sommadx + Convert.ToInt32(dgv.Rows[aa].Cells[dgv.ColumnCount - 1].Value);
            }

            for (int aa = 1; aa < dgv.ColumnCount - 1; aa++)
            {
                sommabas=sommabas+ Convert.ToInt32(dgv.Rows[dgv.RowCount - 1].Cells[aa].Value);
            }


           
            if(sommabas!=sommadx)
            {
                MessageBox.Show($"la somma dei valori di destra ({sommadx}) e i valori in basso ({sommabas}) devono essere uguali");
                return;
            }
            


            for(int aa = 0; aa < dgv.RowCount-1; aa++)
            {
                for(int bb = 1; bb < dgv.ColumnCount-1; bb++)
                {
                    dgv_nord_ovest.Rows[aa].Cells[bb].Value = dgv.Rows[aa].Cells[bb].Value;
                    dgv_Min.Rows[aa].Cells[bb].Value = dgv.Rows[aa].Cells[bb].Value;
                }
            }

            for (int aa = 0; aa < dgv.RowCount - 1; aa++)
            {
                dgv_nord_ovest.Rows[aa].Cells[dgv.ColumnCount-1].Value = dgv.Rows[aa].Cells[dgv.ColumnCount - 1].Value;
                dgv_Min.Rows[aa].Cells[dgv.ColumnCount - 1].Value = dgv.Rows[aa].Cells[dgv.ColumnCount - 1].Value;
                dgv_voghel.Rows[aa].Cells[dgv.ColumnCount - 1].Value = dgv.Rows[aa].Cells[dgv.ColumnCount - 1].Value;
            }
            /*
            for (int aa = 0; aa < dgv.ColumnCount - 1; aa++)
            {
                dgv_nord_ovest.Rows[aa].Cells[dgv.ColumnCount - 1].Value = dgv.Rows[aa].Cells[dgv.ColumnCount - 1].Value;
            }
            */
            for(int a=0; a<dgv.ColumnCount-1;a++)
            {
                dgv_Min.Rows[dgv.RowCount - 1].Cells[a].Value = dgv.Rows[dgv.RowCount - 1].Cells[a].Value;
                dgv_nord_ovest.Rows[dgv.RowCount - 1].Cells[a].Value = dgv.Rows[dgv.RowCount - 1].Cells[a].Value;
                dgv_voghel.Rows[dgv.RowCount - 1].Cells[a].Value = dgv.Rows[dgv.RowCount - 1].Cells[a].Value;
            }

            dgv_Min.Rows[dgv.RowCount - 1].Cells[dgv.ColumnCount - 1].Value = dgv.Rows[dgv.RowCount - 1].Cells[dgv.ColumnCount - 1].Value;
            dgv_nord_ovest.Rows[dgv.RowCount - 1].Cells[dgv.ColumnCount - 1].Value = dgv.Rows[dgv.RowCount - 1].Cells[dgv.ColumnCount - 1].Value;
            dgv_voghel.Rows[dgv.RowCount - 1].Cells[dgv.ColumnCount - 1].Value = dgv.Rows[dgv.RowCount - 1].Cells[dgv.ColumnCount - 1].Value;



        }

        private void cb_algorithm_KeyDown(object sender, KeyEventArgs e)
        {
           return;
        }

        private void cb_algorithm_KeyPress(object sender, KeyPressEventArgs e)
        {
            return;
        }

        private void cb_algorithm_KeyUp(object sender, KeyEventArgs e)
        {
            return;
        }

        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            /*
            for(var a = 1; a<dgv.ColumnCount-1; a++)
            {
                if (e.ColumnIndex == a) // 1 should be your column index
                {
                    int i;

                    if (int.TryParse(Convert.ToString(e.FormattedValue), out i))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Please enter numeric");
                        // label1.Text = "please enter numeric";
                    }
                    
                }
            }
            */
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * ALGORITMO PER VEDERE SE LA CELLA è STATA MODIFICATA CON UNA LETTERA
             
            int x = e.ColumnIndex-1;
            int y = e.RowIndex;
            var bef= Convert.ToInt32(dgv.Rows[y].Cells[x].Value);
            for (int a=1;a<dgv.ColumnCount-1;a++)
            {
                try
                {
                    for (int z = 0; z< dgv.ColumnCount - 1; z++)
                    {
                        int w = Convert.ToInt32(dgv.Rows[z].Cells[a].Value);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("si prega di ijnserire solo valori numerici");
                    dgv.Rows[y].Cells[x].Value = bef;
                }

            }
            */
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() => { calcolaresto(); });
        }
        */
        private static KeyPressEventHandler NumericCheckHandler = new KeyPressEventHandler(NumericCheck);




        private void Grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv.CurrentCell.ColumnIndex > 0)
            {
                e.Control.KeyPress -= NumericCheckHandler;
                e.Control.KeyPress += NumericCheckHandler;
            }
        }



        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;

            if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = default;
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
            {
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            }
        }
    }
}
