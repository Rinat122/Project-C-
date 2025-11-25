# ***Library Management System***

### Project Description
The **Library Management System** is a console application developed in C# aimed at efficiently managing a collection of books in a small library or personal collection.

The program allows users to add, remove, search for, and view information about books using a simple text-based interface. Book data is stored in a text file (books.txt) to ensure persistent storage.

# Key Features:
**Add Book:** Add a new book by specifying its title, author, and publication year.

**View All Books:** Display a complete list of books stored in the system.

**Search Book:** Find books by title or author.

**Remove Book:** Delete an existing book from the collection.

**Save/Load Data:** Automatically saves data to the file (books.txt) and loads it when the application starts.

# **Project Structure**
### **The project consists of the following key files and components:**
|**File**|**Description** |
|:-----|:-----:|
|**Program.cs** | The main entry point of the application. Contains the menu loop and user interaction logic. |
|**Book.cs** | The class model representing the **Book** entity (fields: Title, Author, Year.). |
|**Manager.cs** | The class encapsulating all the business logic for library management (book collection, Add, Remove, Search, Load, Save methods) |
|**books.txt** | The file used for persistent storage of book data. |
|**LibraryManagementSystem.sln** | Visual Studio Solution file.|
|**LibraryManagementSystem.csproj** | C# Project file (.NET Framework). |

# **Technologies**

**Language**: C#

**.NET:** .NET Core / .NET Framework (as determined by the .csproj file)

**Application Type:** Console Application

# **Files**

<img width="227" height="253" alt="Files" src="https://github.com/user-attachments/assets/ddf2110b-d66a-4d08-9e7a-d1736c06c6c1" />

# **Project run (dotnet run)**

<img width="507" height="205" alt="Terminal" src="https://github.com/user-attachments/assets/c0c51ea2-094d-484a-9cd6-eb8866a106bd" />

# **Manager Page**

The Manager page is responsible for managing books. Here you can **add**, **delete**, **search**, and **view all books**.

Access is protected with a simple login system: login: **Rinat**, password: **1234**.

All changes are automatically saved to the **books.txt** file.

<img width="414" height="281" alt="Manager" src="https://github.com/user-attachments/assets/62d75045-6b70-4053-bea2-bfffb36b049f" />
