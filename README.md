# zalenium-demo

#### Requirements for solution
* .NET Core 2.1

#### Requirements for Zalenium
* If you are using Windows you need Windows 10 Pro or Enterprise
* Docker installed and running

#### Starting Zalenium
```shell
# Pull docker-selenium
docker pull elgalu/selenium

# Pull Zalenium
docker pull dosel/zalenium
```

Windows
```
# Run it! (Change yor_user_name and make sure directory "c:/Users/your_user_name/temp/videos" exists)
docker run --rm -ti --name zalenium -p 4444:4444 ^
      -v /var/run/docker.sock:/var/run/docker.sock ^
      -v /c/Users/your_user_name/temp/videos:/home/seluser/videos ^
      --privileged dosel/zalenium start   
```

Linux
```
# Run it!
docker run --rm -ti --name zalenium -p 4444:4444 \
      -v /var/run/docker.sock:/var/run/docker.sock \
      -v /tmp/videos:/home/seluser/videos \
      --privileged dosel/zalenium start    
```

OSX
```
# Run it!
docker run --rm -ti --name zalenium -p 4444:4444 \
      -e DOCKER=17.06.2-ce \
      -v /var/run/docker.sock:/var/run/docker.sock \
      -v /tmp/videos:/home/seluser/videos \
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
