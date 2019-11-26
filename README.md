# zalenium-demo

This setup shows settings for Windows

#### Requirements for solution
* .NET Core 2.1

#### Requirements for Zalenium
* Windows 10 Pro or Enterprise
* Docker installed and running

#### Starting Zalenium
```shell
# Pull docker-selenium
docker pull elgalu/selenium

# Pull Zalenium
docker pull dosel/zalenium

# Run it! (Change yor_user_name and make sure directory "c:/Users/your_user_name/temp/videos" exists)
docker run --rm -ti --name zalenium -p 4444:4444 ^
      -v /var/run/docker.sock:/var/run/docker.sock ^
      -v /c/Users/your_user_name/temp/videos:/home/seluser/videos ^
      --privileged dosel/zalenium start   
```

#### Run Tests
```shell
# Restore nuget packages
dotnet restore

dotnet test .\ZaleniumDemo\ZaleniumDemo.csproj
```

Check out [Zalenium Dashboard](http://localhost:4444/dashboard/) and [Live Preview](http://localhost:4444/grid/admin/live).

For more information check [Zalenium documentation](https://opensource.zalando.com/zalenium/).
