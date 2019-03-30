docker login
docker run --name csharp-eight -it -v C:\Users\david.pine\Source\Repos\IEvangelist.CSharp.Eight:/repo -p 9001:9001 -e PORT=9001 gitpitch/desktop:pro