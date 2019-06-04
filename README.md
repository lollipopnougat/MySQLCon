### MySQLCon

#### 简介

这是给数据库课设铺路的东西，C/S架构的练习
提供了最基本的MySQL数据库查询、修改、插入、删除等功能
采用.NET framework 4.6 开发

#### 运行示例

##### 登录界面

![登录界面](https://cdn.jsdelivr.net/gh/lollipopnougat/website-calculator/img/mysqlvs2.png)

##### 主界面

![登录界面](https://cdn.jsdelivr.net/gh/lollipopnougat/website-calculator/img/mysqlvs3.png)

#### 开发历程

* 2019-4-24 下午看了`MySQL.data.dll`的说明文档，确定使用C# WinForm开发

* 2019-4-24 晚上设计了第一个Form(`Form1`主界面)；采用了读取config `XML`文件来获取MySQL的连接参数；添加了`关于`对话框；顺便设计了关于界面的图片，为项目画了LOGO
Ver 1.0.0.0

* 2019-4-25 晚上修改项目，设计了登陆界面(`Form2`)并将程序入口点修改为Form2的新对象上；取消了`XML`配置文件的使用；通过与大佬交流发觉 .NET 4.6.1似乎有点超前了,因此降了一个版本
Ver 1.0.1.0

* 2019-4-26 晚上修改项目，主要是BUG修复，重新配置了调用关系；恢复`Form1`为入口点，`Form2`实例化为`Form1`类的一个对象，在调用`Form1`构造函数时先构造`Form1`获取登陆信息，从而解决了选项菜单修改数据库登陆信息的问题。
Ver 1.0.2.0

* 2019-5-1 修改项目，添加了四个`radio button`控制查、插、改、删，在左下角添加了结果输出；登陆界面稍微美化了一下；添加查询结果导出到excel的功能；添加了菜单栏图标
Ver 2.0.0.1

#### 安装依赖并运行

请使用VS2017或更新版本直接打开sln文件(VS要安装了.NET桌面开发功能负载)，运行还要添加`mysql.data.dll`的引用，需要手动设置，
`mysql.data.dll`文件可以到[这里](https://dev.mysql.com/downloads/windows/visualstudio/)下载，
在页面底部有个**Windows (x86, 32-bit), ZIP Archive**文件，下载后解压，
打开此VS项目解决方案，在项目中添加引用，在弹出的引用管理器中选择-**浏览**，然后找到刚刚解压的文件夹，![添加引用](https://cdn.jsdelivr.net/gh/lollipopnougat/website-calculator/img/mysqlvs1.png)
进入.NET 4.6目录下找到`mysql.data.dll`，添加即可。此时点击VS工具栏的启动按钮应该可以运行了


#### 注意

* 导出到excel需要你的电脑上安装了excel
* 连接mysql数据库前需要先确保mysql服务已经启动
* 密码如果没有，留空即可
* 若已经启动了服务但数据库仍无法连接，请检查你数据库用户的远程连接设置
* 要求 .NET Framework 4.6版本及以上，没有安装(Windows 10已经自带无需安装)可以到[这里](http://download.microsoft.com/download/1/4/A/14A6C422-0D3C-4811-A31F-5EF91A83C368/NDP46-KB3045560-Web.exe)下载(不支持XP)
