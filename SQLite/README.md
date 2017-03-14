To build the Net library download the source (sqlite-netFx-source) from the [official website](http://system.data.sqlite.org/index.html/doc/trunk/www/downloads.wiki).  
Run the following command in System.Data.SQLite directory to build the library without Interop:
```
MSBuild System.Data.SQLite.2012.csproj /t:Rebuild /p:Configuration=Release /p:UseInteropDll=false /p:UseSqliteStandard=true
```  
The 2012 project targets Net 4.5  
  
The library present in this repository was compiled without Interop, so it can interact with sqlite3 in Windows as well as Linux (Mono)  

###Windows
For windows, you need sqlite3.dll which is included in the repository but you can also download it from the SQLite [website](https://www.sqlite.org/download.html).  
I recommend to place the file in the windows directory or somewhere in your PATH, so it's accessible to all applications.  

###Linux
For Linux (Mono) you shouldn't need to do anything besides installing sqlite (which might be already installed).  
