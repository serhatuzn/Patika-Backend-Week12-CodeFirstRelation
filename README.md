# PatikaCodeFirstDb2 📚💻

Bu proje, **Code First** yaklaşımıyla **Entity Framework Core** kullanarak bir veritabanı oluşturmayı ve iki tablo arasındaki ilişkiyi yapılandırmayı amaçlamaktadır. 👨‍💻📊

## 🚀 Proje Özeti

Bu projede, **Users** (Kullanıcılar) ve **Posts** (Gönderiler) adında iki tablo oluşturduk. **Bir kullanıcı** birden fazla **gönderi** oluşturabilir, ancak her **gönderi** yalnızca bir **kullanıcıya** ait olabilir. Bu, **birden çok** (`one-to-many`) ilişkisidir. 🤝

- **User** tablosu: Kullanıcı bilgileri (username, email) içerir.
- **Post** tablosu: Gönderi başlıkları ve içerikleri bulunur.

## 🔧 Kullanılan Teknolojiler

- **C#** 💻
- **Entity Framework Core** 🛠️
- **SQL Server** (Veritabanı) 🗄️
- **Code First Yaklaşımı** 🚀

## 🗂️ Veritabanı Yapısı

- **Users Tablosu**: Kullanıcıların temel bilgileri (id, username, email).
- **Posts Tablosu**: Gönderilerin başlık ve içeriği (id, title, content, userId).

## 📋 Veritabanı İlişkisi

- **Bir kullanıcı birden fazla gönderi oluşturabilir**.
- **Her gönderi yalnızca bir kullanıcıya ait olabilir**.

## 🛠️ Migration ve Veritabanı Güncelleme

Veritabanınızı oluşturmak ve güncellemek için aşağıdaki komutları kullanabilirsiniz:

1. **Migration ekleme**:

   ```bash
   dotnet ef migrations add InitialCreate
   ```

2. **Veritabanını güncelleme**:
   ```bash
   dotnet ef database update
   ```

   ## 📦 Proje Yapısı

   Proje, aşağıdaki dosya ve klasörlerden oluşmaktadır:

 - **CodeFirstRelation**: Proje klasörü.
 - **Models**: Veritabanı tabloları için model sınıfları.
 - **Data**: Veritabanı işlemleri için context sınıfı.
 - **Migrations**: Migration dosyaları.
 - **Program.cs**: Program başlangıç noktası.
 - **README.md**: Proje dokümantasyonu.
