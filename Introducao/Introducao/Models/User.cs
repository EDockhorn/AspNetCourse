namespace Introducao.Models
{
    public class User
    {
        public string Name { get; set; }
        public int YearsOld { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Observations { get; set; }

        //public User()
        //{
        //    Name = "Johnny Erick Dockhorn";
        //    YearsOld = 20;
        //    Login = "johnnydock";
        //    Email = "johnnyerick111@hotmail.com";
        //    Password = "123131";
        //    ConfirmPassword = "12121";
        //    Observations = "Observações Qualquer";
        //}
    }
}