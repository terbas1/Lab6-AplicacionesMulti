using Lab6.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lab6.ViewModels
{

    public class MylistPageViewModel
    {
        public ObservableCollection<MylistModel> ContacList { get; set; }

        public MylistPageViewModel()
        {
            ContacList = new ObservableCollection<MylistModel> { };
            ContacList.Add(new MylistModel { Nombre = "Edwin Daniel", Apellido = "Baltazar Terbullino", Edad = "23", Image = "https://pbs.twimg.com/profile_images/1042591952284340224/yY7C34o6_400x400.jpg" });
            ContacList.Add(new MylistModel { Nombre = "Angie Mishel", Apellido = "Yamunaque Osores", Edad = "20", Image = "https://scontent.flim18-3.fna.fbcdn.net/v/t1.0-9/82469042_2756609204421440_5710843925581791232_o.jpg?_nc_cat=101&_nc_sid=09cbfe&_nc_eui2=AeEEp6uLpWobokAhqy2USDmG4NMFvpgq_zPg0wW-mCr_Mzpt4aGo1sGItoIkV6g7DX4l93_51scNZMfrpkd4xcBs&_nc_ohc=8CNOqfR4ImYAX_6hGx9&_nc_ht=scontent.flim18-3.fna&oh=b3bee46cdf95ea1f9d9d7941243214e6&oe=5ED526DA" });
            ContacList.Add(new MylistModel { Nombre = "Yomira ", Apellido = "Valladolid Valladolid", Edad = "23", Image = "https://scontent.flim18-1.fna.fbcdn.net/v/t1.0-9/72154251_1273295726208941_3898709760685375488_n.jpg?_nc_cat=103&_nc_sid=09cbfe&_nc_eui2=AeGDa4u0KaWOCjhD4pDaNxT5-C75YAFafsL4LvlgAVp-wlhar2PydxCa6Sgh3VJn0stMlZuG5SuUhH0qGUb0yEn-&_nc_ohc=VSNg5in2qbEAX9ex0XP&_nc_ht=scontent.flim18-1.fna&oh=185dfdfe77abd1d66a7675660c1e8d29&oe=5ED6B363" });
            ContacList.Add(new MylistModel { Nombre = "Maricielo ", Apellido = "Rojas Piña", Edad = "22", Image = "https://scontent.flim18-1.fna.fbcdn.net/v/t1.0-9/84839640_3396478590425147_784686260076675072_n.jpg?_nc_cat=105&_nc_sid=09cbfe&_nc_eui2=AeHixdWr0-vmcbMXGq8sNfNYXQDA56KNY15dAMDnoo1jXt2_6rhWiuCO3QjgoKjbTnPFsYNOG2oQ-q9VC7jLZhXK&_nc_ohc=NChS6TqQjYIAX-aQIaq&_nc_ht=scontent.flim18-1.fna&oh=371304140309d50bae569031482cc1a8&oe=5ED66D1C" });
            ContacList.Add(new MylistModel { Nombre = "Branayn Esnayder", Apellido = "Benancio Casimiro", Edad = "25", Image = "https://scontent.flim18-3.fna.fbcdn.net/v/t1.0-9/94392742_3796969273708140_3938685774383284224_o.jpg?_nc_cat=108&_nc_sid=09cbfe&_nc_eui2=AeGenBlGs6wKdR2By-_kSo38RsY1HktnByFGxjUeS2cHIW_nNVkn74eQs0Znfne-x17zuyehsUUixGqPP9V7rqPj&_nc_ohc=LWiAQTz1dYAAX-jw4TT&_nc_ht=scontent.flim18-3.fna&oh=6c3d79e0fc164c1ac89d53de2e7615c6&oe=5ED499E8" });

        }

    }
}
