using Microsoft.Win32;

namespace List_Separator_Customize
{
    public partial class Form_Main : Form
    {
        readonly String regInternational = "Control Panel\\International";

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(this.regInternational))
                {
                    Object separator = key.GetValue("sList");
                    if (separator != null)
                    {
                        if (separator.ToString() == ",")
                        {
                            radioButton1_Comma.Checked = true;
                        }

                        if (separator.ToString() == "|")
                        {
                            radioButton2_Pipe.Checked = true;
                        }

                        if (separator.ToString() == ":")
                        {
                            radioButton3_Colon.Checked = true;
                        }

                        if (separator.ToString() == ";")
                        {
                            radioButton4_SemiColon.Checked = true;
                        }

                        if (separator.ToString() == "/")
                        {
                            radioButton5_BackSlash.Checked = true;
                        }

                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            String separator;

            if (radioButton1_Comma.Checked == true)
            {
                separator = ",";
            }
            else if (radioButton2_Pipe.Checked == true)
            {
                separator = "|";
            }
            else if (radioButton3_Colon.Checked == true)
            {
                separator = ":";
            }
            else if (radioButton4_SemiColon.Checked == true)
            {
                separator = ";";
            }
            else if (radioButton5_BackSlash.Checked == true)
            {
                separator = "/";
            }
            else
            {
                separator = ",";
            }

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(this.regInternational, true))
                {
                    key.SetValue("sList", separator);
                }

                MessageBox.Show("Done, Please restart application to take effect.", "Operation Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}