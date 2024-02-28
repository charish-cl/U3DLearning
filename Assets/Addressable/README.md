# 3中资源加载方式

https://blog.csdn.net/linxinfa/article/details/108894280



# Addressable参考文章

https://blog.csdn.net/linxinfa/article/details/122390621

# 官方文档

https://docs.unity3d.com/Packages/com.unity.addressables@2.0/manual/index.html





`RemoteGroup`打出来的资源就不会在包体内了，它会被打到工程目录的`ServerData/Android`目录中，

加载时也从远程加载

![image-20240228123500609](assets/image-20240228123500609.png)

# 打包出来的文件

![image-20240228124447316](assets/image-20240228124447316.png)



## Win11 `Hosting Services`会无法访问

注：如果你是`win11`系统，可能使用`Hosting Services`会无法访问，具体原因不明，`win11`各种恶心的问题，放弃治疗，把资源放到`https`服务器可以正常加载



![image-20240228130149310](assets/image-20240228130149310.png)