using CRUD_Operations.Infrastructure.Context;
using CRUD_Operations.Models.Concrate;

#region Create 
//// Oluşturduğumuz database'e yeni veriler yüklemek için yapılacak işlem
//using (var db = new AppDbContext())
//{
//    List<Category> categories = new List<Category>()
//    {
//        new Category
//        {
//            Name = "Eldiven",
//            Description = "Everlast"
//        },
//        new Category
//        {
//            Name = "Manav",
//            Description = "Meyve - Sebze Ürünleri"
//        },
//        new Category
//        {
//            Name = "Şarküteri",
//            Description = "Süt Ürünleri"
//        },
//        new Category
//        {
//            Name = "Kasap",
//            Description  = "Et - Tavuk"
//        },
//    };
//    foreach (var category in categories)
//    {
//        db.Categories.Add(category);
//        if (db.SaveChanges() > 0)
//        {
//            Console.WriteLine($"{category.Name} kategori {category.CratedDate} tarihinde eklendi!");
//        }
//        else
//        {
//            Console.WriteLine("Kategori Eklenirken Bir Hata Oluştu!");
//        }

//    }
//}
#endregion

#region Read 
//// Oluşturduğumuz database'i okumak için yapılan işlemeler

//using (var db = new AppDbContext())
//{
//    var categories = db.Categories.Where(x => x.Status != CRUD_Operations.Models.Abstract.Status.Passive)
//                                  .Select(x => new
//                                   {
//                                       x.Id,
//                                       x.Name,
//                                       x.Description,
//                                       x.CreatedDate,
//                                       x.Status

//                                   }).ToList();
//    foreach (var category in categories)
//    {
//        Console.WriteLine($"Id: {category.Id}\nAd: {category.Name}\nAçıklama: {category.Description}\nEkleme Tarihi: {category.CreatedDate}\nDurum: {category.Status}\n================");
//    }
//}
#endregion

#region Update
//// Oluşturduğumuz  database üzerinde değişiklik yapmak istediğimizde izleyeceğimiz yollar

//using (var db = new AppDbContext())
//{
//    var category = db.Categories.FirstOrDefault(x=> x.Id == 3);

//    category.Name = "Değiştirilmiş Kategori";
//    category.Description = "Değiştirilmiş Açıklama";
//    category.UpdatedDate = DateTime.Now;
//    category.Status = CRUD_Operations.Models.Abstract.Status.Modified;

//    db.Categories.Update(category);

//    if (db.SaveChanges()>0)
//    {
//        Console.WriteLine("Kategori Güncellendi!");
//    }
//    else
//    {
//        Console.WriteLine("Kategori Güncellenirken Bir Hata Oluştu");
//    }
//}
#endregion

#region Delete
//// Oluşturduğumuz database'imizden bir veri silmek için yapılacak işlemler

//using (var db = new AppDbContext())
//{
//    var deleteCategory = db.Categories.FirstOrDefault(x => x.Id == 3);

//    deleteCategory.DeletedDate = DateTime.Now;
//    deleteCategory.Status = CRUD_Operations.Models.Abstract.Status.Passive;

//    db.Categories.Update(deleteCategory);
//    if (db.SaveChanges() > 0)
//    {
//        Console.WriteLine("Kategori Silindi");
//    }
//    else
//    {
//        Console.WriteLine("Kategori Silinemedi");
//    }

//    var categories = db.Categories.Where(x => x.Status != CRUD_Operations.Models.Abstract.Status.Passive)
//                                    .Select(x => new
//                                    {
//                                        x.Id,
//                                        x.Name,
//                                        x.Description,
//                                        x.CreatedDate,
//                                        x.Status
//                                    }).ToList();
//}
#endregion

#region Example
#region Example - 1
//// Kullanıcıdan kategori adı ve açıklaması alıp database'e kayıt edelim.

//Console.Write("Lütfen Kategori Adı Giriniz:");
//string categoryName = Console.ReadLine();
//Console.Write("Lütfen Açıklamyı Giriniz:");
//string categoryDescription = Console.ReadLine();

//using (var db = new AppDbContext())
//{
//    var category = new Category
//    {
//        Name = categoryName,
//        Description = categoryDescription
//    };
//    db.Categories.Add(category);
//    if (db.SaveChanges() > 0)
//    {
//        Console.WriteLine($"\n{categoryName} Kategorisi Sisteme Kaydedilmiştir");
//    }
//    else
//    {
//        Console.WriteLine("Sisteme Kaydedilemedi!!");
//    }
//}
#endregion

#region Example - 2 
//// Kullanıcıdan Alınan Kategori adına göre kategoriyi göstermek

//Console.Write("Lütfen Bir Kategori Adını Giriniz: ");
//string categoryName = Console.ReadLine();
//Console.WriteLine("Kategori Bilgileri: ");

//using (var db = new AppDbContext())
//{
//    var category = db.Categories.FirstOrDefault(x => x.Name == categoryName && x.Status != CRUD_Operations.Models.Abstract.Status.Passive);

//	if (category is not null)
//	{
//        Console.WriteLine($"Id: {category.Id}\nAd: {category.Name}\nAçıklama: {category.Description}\nEkleme Tarihi: {category.CreatedDate}");
//    }
//	else
//	{
//        Console.WriteLine("Bu İsimde Bir Kategori Yoktur!");
//    }
//}
#endregion

#region Example - 3 
//// Kullanıcının girdiği Id Bilgisine göre güncelleme yamasını sağlayalım.

//try
//{
//    Console.Write("Güncellemek İstediğiniz Kategori ID'sini Giriniz: ");
//    int id = Convert.ToInt32(Console.ReadLine());

//    using (var db = new AppDbContext())
//    {
//        var category = db.Categories.FirstOrDefault(x => x.Id == id);
//        if (category != null)
//        {
//            Console.Write($"Yeni Kategori Adını Giriniz (Şuan ki Adı: {category.Name}): ");
//            string newCategoryName = Console.ReadLine();
//            Console.Write($"Yeni Kategori Açıklaması Giriniz (Şuan ki Kategori Açıklaması: {category.Description}): ");
//            string newCategoryDescription = Console.ReadLine();

//            category.Name = newCategoryName;
//            category.Description = newCategoryDescription;

//            category.UpdatedDate = DateTime.Now;
//            category.Status = CRUD_Operations.Models.Abstract.Status.Modified;
//            db.Categories.Update(category);

//            if (db.SaveChanges() > 0)
//            {
//                Console.Write("Kategoriniz Güncellenmiştir. Yeni Kategori bilgileriniz : ");
//                var newCategory = db.Categories.FirstOrDefault(x => x.Id == category.Id);
//                Console.Write($"Id: {newCategory.Id}\nAd: {newCategory.Name}\nAçıklama: {newCategoryDescription}\nEkleme Tarihi: {newCategory.CreatedDate}\nGüncelleme Tarihi: {newCategory.UpdatedDate}\nDurum: {newCategory.Status}");
//            }
//            else
//            {
//                Console.Write("Güncelleme Sırasında Bir Hata Oluştu!!");
//            }
//        }
//    }
//}
//catch (Exception)
//{

//    Console.Write("Lütfen Id Değeri İçin Bir Sayı Giriniz: ");
//}
#endregion

#region Example - 4 
//// Kullanıcıdan Alınan Kategori Adına Sahip Kategori Bilgilerini Siliniz.

//Console.Write("Silmek İstediğiniz Kategori Adını Giriniz: ");
//string categoryName = Console.ReadLine();

//using (var db = new AppDbContext())
//{
//    var category = db.Categories.FirstOrDefault(x => x.Name == categoryName && x.Status != CRUD_Operations.Models.Abstract.Status.Passive);

//    if (category is not null)
//    {
//        category.DeletedDate = DateTime.Now;
//        category.Status = CRUD_Operations.Models.Abstract.Status.Passive;
//        db.Categories.Update(category);

//        if (db.SaveChanges() > 0 )
//        {
//            Console.WriteLine("Kategori Silinmiştir");
//        }
//        else
//        {
//            Console.WriteLine("Kategori Silinirken Bir Hata Oluştu!");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Böyle Bir Kategori Sistemde Kayıtlı Değildir!");
//    }
//}
#endregion

#endregion
