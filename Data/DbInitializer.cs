using ShipAndTrack.Models;
namespace ShipAndTrack.Data{
    public static class DbInitializer{
        public static void Initialize(ShipAndTrackContext context){
            if(context.Users.Any()){
                return;
            }
            
            var users = new User[]
            {
                new User{Email="alainluthier@gmail.com",Password="12345678",FullName="Alain Ramos",Phone="+59164123482"}
            };
            context.Users.AddRange(users);
            context.SaveChanges();

            var addresses = new Address[]{
                new Address{Street="Beltran N. 12345",City="La Paz",State="La Paz",Country="Bolivia",PostalCode="591",Phone="+5916543210",Recipient="Rodrigo Ramos",UserID=1},
                new Address{Street="Av.ABC, N.55",City="Santa Fe",State="Santa Fe",Country="Argentina",PostalCode="5520",Phone="+0916543210",Recipient="Luz Gonzales",UserID=1},
                new Address{Street="444 Alaska Avenue",City="Torrance",State="California",Country="USA",PostalCode="111",Phone="+9126543210",Recipient="Paul Jarvis",UserID=1}
            };
            context.Addresses.AddRange(addresses);
            context.SaveChanges();

            var packages = new Package[]{
                new Package{TrackingNumber="AB485C1044",Length=21.5,Width=10,Height=15.5,Weight=8,Description="Electronic parts",AddressID=1,UserID=1},
                new Package{TrackingNumber="US11521880",Length=5,Width=30,Height=35,Weight=10,Description="Clothes",AddressID=3,UserID=1}
            };
            context.Packages.AddRange(packages);
            context.SaveChanges();

            var trackings = new Tracking[]{
                new Tracking{PackageID=1,CreatedAt=DateTime.Parse("2023-12-01"),Status="Registered"},
                new Tracking{PackageID=1,CreatedAt=DateTime.Parse("2023-12-02"),Status="On the Way"},
                new Tracking{PackageID=1,CreatedAt=DateTime.Parse("2023-12-03"),Status="Arrived"},
                new Tracking{PackageID=1,CreatedAt=DateTime.Parse("2023-12-04"),Status="Received"},
                new Tracking{PackageID=2,CreatedAt=DateTime.Parse("2024-01-13"),Status="Registered"},
            };
            context.Trackings.AddRange(trackings);
            context.SaveChanges();
        }

    }
}