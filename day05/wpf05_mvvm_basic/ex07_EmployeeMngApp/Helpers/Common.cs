namespace ex07_EmployeeMngApp.Helpers
{
    class Common
    {
        public static readonly string CONNSTRING = "Data Source=127.0.0.1;" +
                                                   "Initial Catalog=EMS;" +
                                                   "Persist Security Info=True;" +
                                                   "User ID=ems_user; Password = ems_p@ss;" +
                                                   "Encrypt=False";
    } // 드래그해서 가져왔을 때 패스워드가 빠져있어서 따로 넣어줘야 함
}
