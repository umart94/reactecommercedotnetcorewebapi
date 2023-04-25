using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context,UserManager<User> userManager)
        {
            if(!userManager.Users.Any()){
                var user = new User {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user,"Pa$$w0rd");
                await userManager.AddToRoleAsync(user,"Member");

                var admin = new User {
                    UserName = "umartariq",
                    Email = "umartariqx94@gmail.com"
                };

                await userManager.CreateAsync(admin,"Pa$$w0rd");
                await userManager.AddToRolesAsync(admin,new[] {"Member","Admin"});
            }
            if(context.Products.Any()){
                return;
            }

            var products = new List<Product>{
                new Product
                {
                    Name = "Samsung Galaxy A54",
                    Description =
                        "Android 13, One UI 5.1 Octa-core (4x2.4 GHz Cortex-A78 & 4x2.0 GHz Cortex-A55)",
                    Price = 49999,
                    PictureUrl = "/images/products/samsung-galaxy-a54.png",
                    Brand = "Samsung",
                    Type = "Mobiles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Google Pixel 7 Pro",
                    Description = "Custom-made Google Tensor chip Pixel’s newest powerful processor is custom built with Google AI and makes Pixel 7 Pro faster, more efficient, and more secure. And it delivers even more helpful features and the best photo and video quality yet.",
                    Price = 15000,
                    PictureUrl = "/images/products/google-pixel7.png",
                    Brand = "Google",
                    Type = "Mobiles",
                    QuantityInStock = 100
                },
               
                new Product
                {
                    Name = "Samsung Galaxy A23",
                    Description =
                        "Android 12, upgradable to Android 13, One UI 5 Qualcomm SM6225 Snapdragon 680 4G (6 nm) Octa-core (4x2.4 GHz Kryo 265 Gold & 4x1.9 GHz Kryo 265 Silver) Wi-Fi 802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct",
                    Price = 21000,
                    PictureUrl = "/images/products/samsung-galaxy-a23.png",
                    Brand = "Samsung",
                    Type = "Mobiles",
                    QuantityInStock = 100
                }
                ,
                new Product
                {
                    Name = "Fitbit Charge 5 Activity Monitoring Tracker",
                    Description =
                        "Do what's best for your body with an ECG app for your heart & an EDA sensor for your stress on our most advanced fitness & health tracker",
                    Price = 14995,
                    PictureUrl = "/images/products/fitbit-activity-tracker.png",
                    Brand = "Fitbit",
                    Type = "Health",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Accu-Chek Active blood glucose meter",
                    Description =
                        "Smaller than before, but with a 10 % bigger display Easy to use, with only 2 buttons to operate Safe, with alerts for expired strips or underdosing Smart, reports up to 90 days of test results Convenient testing, use strips in or out of the meter",
                    Price = 1500,
                    PictureUrl = "/images/products/accucheck-blood-glucose.png",
                    Brand = "Accu-Check",
                    Type = "Health",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "5 Series® Upper Arm Blood Pressure Monitor Model: BP7200 ",
                    Description =
                        "The OMRON 5 Series Upper Arm home blood pressure monitor is designed for accuracy and stores 120 blood pressure readings for two users (60 per user), and includes a wide-range D-ring cuff (fits arms 9” to 17” in circumference).",
                    Price = 5999,
                    PictureUrl = "/images/products/omron-blood-pressure.png",
                    Brand = "OMRON",
                    Type = "Health",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pulse 7S Pro",
                    Description =
                        "Our patented VTEC™ nano sensors use four optical multiplex transmitters to provide accurate results every time. Accurately determine your SpO2 (blood oxygen level) in under 7 seconds and easily view results with large digits",
                    Price = 1400,
                    PictureUrl = "/images/products/oxiline-pulse.png",
                    Brand = "Oxiline",
                    Type = "Health",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MOMENTUM 4 Wireless",
                    Description =
                        "Sennheiser Signature Sound Customized sound Adaptive Noise Cancellation Transparency Mode Premium Comfort Top-Tier Battery Life Crystal-clear Calls",
                    Price = 37995,
                    PictureUrl = "/images/products/sennheiser-headphone.png",
                    Brand = "Sennheiser",
                    Type = "Electronics",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MP3 Player",
                    Description =
                        "SanDisk 8GB Clip Jam MP3 Player, Black - microSD card slot and FM Radio - SDMX26-008G-G46K",
                    Price = 3499,
                    PictureUrl = "/images/products/sandisk-clip.png",
                    Brand = "SanDisk",
                    Type = "Electronics",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sony RX100 VII Compact Camera, Unrivalled AF",
                    Description =
                        "Inside its compact body the RX100 VII is packed with everything it takes to deliver gorgeous images. The 24-200mm1 zoom lens is complemented by 0.02-sec.2 super fast AF, new Real-time Tracking and Real-time Eye AF, plus enhanced image stabilisation and an external microphone jack for high-quality movie shooting.",
                    Price = 19999,
                    PictureUrl = "/images/products/Sony-RX100-VII.png",
                    Brand = "Sony",
                    Type = "Electronics",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Q950TS QLED 8K Smart TV",
                    Description = "Q950TS QLED 8K Smart TV Infinity Screen Quantum Processor 8K",
                    Price = 345679,
                    PictureUrl = "/images/products/q950ts.png",
                    Brand = "Samsung",
                    Type = "Electrical",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Haier HSU-12HPM/012SDC(W)-T3 thunder inverter AC",
                    Description =
                        "HSU-12HPM/012SDC(W)-T3 T3 Ultra Big Outdoor Upto 52°C Full BTU Wide Voltage With Hyper PCB",
                    Price = 59964,
                    PictureUrl = "/images/products/haier-ac.png",
                    Brand = "Haier",
                    Type = "Electrical",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dawlance Elegance+ 1.5 Ton Inverter Split AC",
                    Description =
                        "Dawlance air conditioners are the perfect solution for cooling your home or business. Their rapid cooling speeds mean that you can be comfortable sooner than ever before.",
                    Price = 71922,
                    PictureUrl = "/images/products/dawlance-ac.png",
                    Brand = "Dawlance",
                    Type = "Electrical",
                    QuantityInStock = 100
                }
            };

            foreach(var product in products){
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
        
    }
}