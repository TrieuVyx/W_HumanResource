using HumanResource.src.Controller;
using HumanResource.src.DTO.Request;
using HumanResource.src.DTO.Response;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace HumanResource.src.View.Employee
{
    public partial class Update : Form
    {
        private DTO.Request.EmployeeReqDTO employeeReqDTO;
        private readonly RoleController roleController;
        private readonly EmployeeController employeeController;
        private readonly DepartmentController departmentController;
        private readonly AccountController accountController;
        private readonly EducationController educationController;
        private readonly DegreeController degreeController;
        public Update()
        {
            InitializeComponent();
            employeeReqDTO = new EmployeeReqDTO();



            employeeController = new EmployeeController();
            roleController = new RoleController();
            departmentController = new DepartmentController();
            accountController = new AccountController();    
            educationController = new EducationController();    
            degreeController = new DegreeController();  


            txtBirthday.Format = DateTimePickerFormat.Custom;
            txtBirthday.CustomFormat = "dd/MM/yyyy";
            ListComboBox();
            Lock();
        }
        readonly int x = 175;
        readonly int y = 10;
        readonly int height = 470;
        readonly int width = 700;

        internal new void ControlAdded(List<EmployeeReqDTO> employeeReqs)
        {
            MainApplication mainApplication = new MainApplication();
            this.Bounds = new Rectangle(x, y, width, height);
            this.StartPosition = FormStartPosition.Manual;
            this.MdiParent = mainApplication.MdiParent;
            this.Show();
            foreach (var employeeReq in employeeReqs)
            {
                TxtEmail.Text = employeeReq.Email;
                TxtAddress.Text = employeeReq.AddressEmployee;
                TxtFullName.Text = employeeReq.EmployeeName;
                TxtID.Text = employeeReq.EmployId.ToString();
                TxtPhone.Text = employeeReq.Phone;
                txtBirthday.Value = employeeReq.DateOfBirth;
                txtCboRole.SelectedValue = employeeReq.RoleId;
                txtComboDep.SelectedValue = employeeReq.DepId;
                txtComboDegree.SelectedValue = employeeReq.DegreeId;
                txtComboEdu.SelectedValue = employeeReq.EducationId;
                txtComboAccount.SelectedValue = employeeReq.AccountId;

                byte[] imageData = Convert.FromBase64String(employeeReq.Avatar);

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    AvatarImage.Image = image;
                    AvatarImage.SizeMode = PictureBoxSizeMode.StretchImage;
                };


                if (employeeReq.Gender == "Male")
                {
                    RdMale.Checked = true;
                }
                else
                {
                    RdFemale.Checked = false;
                }

            }
        }
        private void ListComboBox()
        {
            try
            {
                List<RoleReqDTO> roleReqDTO = roleController.FindAllRole();
                List<DepartmentResDTO> departments = departmentController.FindAllList();
                List<AccountResDTO> account = accountController.FindAllAccount();
                List<EducationResDTO> education = educationController.FindAllEducation();
                List<DegreeResDTO> degree = degreeController.FindAllDegree();


                if (roleReqDTO.Count > 0)
                {
                    txtCboRole.DataSource = roleReqDTO;
                    txtCboRole.DisplayMember = "RoleName";
                    txtCboRole.ValueMember = "RoleId";
                    txtCboRole.SelectedIndex = 1;


                    txtComboDep.DataSource = departments;
                    txtComboDep.DisplayMember = "DepDesc";
                    txtComboDep.ValueMember = "DepId";
                    txtComboDep.SelectedIndex = 1;

                    txtComboAccount.DataSource = account;
                    txtComboAccount.DisplayMember = "FullName";
                    txtComboAccount.ValueMember = "AccountId";
                    txtComboAccount.SelectedIndex = 1;

                    txtComboEdu.DataSource = education;
                    txtComboEdu.DisplayMember = "EducationName";
                    txtComboEdu.ValueMember = "EducationId";
                    txtComboEdu.SelectedIndex = 1;

                    txtComboDegree.DataSource = degree;
                    txtComboDegree.DisplayMember = "DegreeName";
                    txtComboDegree.ValueMember = "DegreeId";
                    txtComboDegree.SelectedIndex = 1;

                }
                else
                {
                    txtCboRole.SelectedIndex = -1;
                    txtCboRole.DataSource = null;

                    txtComboDep.SelectedIndex = -1;
                    txtComboDep.DataSource = null;

                    txtComboAccount.SelectedIndex = -1;
                    txtComboAccount.DataSource = null;


                    txtComboDegree.SelectedIndex = -1;
                    txtComboDegree.DataSource = null;


                    txtComboEdu.SelectedIndex = -1;
                    txtComboEdu.DataSource = null;

                    MessageBox.Show("Lỗi không tồn tại danh sách ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Phát Sinh Từ UPDATE " + ex.Message);

            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Lock()
        {
            TxtID.ReadOnly = true;
            TxtID.Enabled = false;
        }

        private void BtnRefer_Click(object sender, EventArgs e)
        {

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string FullName = TxtFullName.Text;
                string Phone = TxtPhone.Text;
                string Email = TxtEmail.Text;
                string Address = TxtAddress.Text;
                string Id = TxtID.Text;
                string Gender = string.Empty;
                if (RdMale.Checked)
                {
                    Gender = "Male";
                }
                else if (RdFemale.Checked)
                {
                    Gender = "Female";
                }
                DateTime selectedDate = txtBirthday.Value;
                employeeReqDTO = new EmployeeReqDTO();
                if (!string.IsNullOrEmpty(TxtID.Text))
                {
                    employeeReqDTO.EmployId = int.Parse(TxtID.Text);
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không?!", "Xác nhận câp nhật", MessageBoxButtons.YesNo);

                    if (int.TryParse(txtCboRole.SelectedValue.ToString(), out int roleId))
                    {
                        employeeReqDTO.RoleId = roleId;
                    }
                    if (int.TryParse(txtComboDep.SelectedValue.ToString(), out int depId))
                    {
                        employeeReqDTO.DepId = depId;
                    }
                    if (int.TryParse(txtComboEdu.SelectedValue.ToString(), out int educationId))
                    {
                        employeeReqDTO.EducationId = educationId;
                    }
                    if (int.TryParse(txtComboDegree.SelectedValue.ToString(), out int degreeId))
                    {
                        employeeReqDTO.DegreeId = degreeId;
                    }
                    if (int.TryParse(txtComboAccount.SelectedValue.ToString(), out int accountId))
                    {
                        employeeReqDTO.AccountId = accountId;
                    }
                    if (result == DialogResult.Yes)
                    {
                        employeeReqDTO.EmployId = int.Parse(Id);
                        employeeReqDTO.AddressEmployee = Address;
                        employeeReqDTO.Phone = Phone;
                        employeeReqDTO.Email = Email;
                        employeeReqDTO.EmployeeName = FullName;
                        employeeReqDTO.DateOfBirth = selectedDate;
                        employeeReqDTO.Gender = Gender;
                        employeeReqDTO.RoleId = roleId;
                        employeeReqDTO.EducationId = educationId;
                        employeeReqDTO.DepId = depId;
                        employeeReqDTO.DegreeId = degreeId;
                        employeeReqDTO.AccountId = accountId;
                       
                        bool employeeReqs = employeeController.FindAndUpdate(employeeReqDTO);
                        if (employeeReqs)
                        {
                            MessageBox.Show("CẬP NHẬT THÀNH CÔNG, VUI LÒNG ẤN RESET ĐỂ CẬP NHẬT LẠI");
                        }
                        else
                        {
                            MessageBox.Show("CẬP NHẬT THẤT BẠI");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Bạn đã huỷ lựa chọn");
                    }
                }
                else
                {
                    MessageBox.Show("ID không được để trống: ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi: " + ex.Message);
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(TxtID.Text);
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        Image image = Image.FromFile(filePath);
                        if (image != null)
                        {
                            MessageBox.Show("Hình ảnh đã tải thành công.");
                            AvatarImage.Image = image;

                            byte[] fileData;
                            using (MemoryStream ms = new MemoryStream())
                            {
                                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                fileData = ms.ToArray();
                            }
                            int employeeId = int.Parse(TxtID.Text);
                            employeeController.SaveFile(fileData, employeeId);

                            MessageBox.Show("Hình ảnh đã được lưu trữ.");
                        }
                        else
                        {
                            MessageBox.Show("Không thể tải hình ảnh.");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("đã xảy ra lỗi" + ex.Message);
            }
        }
    }
}
