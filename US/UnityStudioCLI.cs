
using System;
namespace Unity_Studio
{
    class UnityStudioCLI
    {
        public static bool enableDebugPrint = false;

        static void Main()
        {
            var args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                var cmd = args[1];
                var abPath = "";
                switch (cmd)
                {
                    case "--list":
                        if (args.Length>2){
                            abPath = args[2];
                            enableDebugPrint = false;
                            UnityStudio.LoadBundleFile(abPath,false,"");
                            return;
                        }
                        break;
                    case "--dump":
                    /*
                        Extract files inside assetbundle file to savePath.
                     */
                        var savePath = "";
                        if (args.Length>2){
                            abPath = args[2];
                            if (args.Length>3){
                                savePath = args[3];
                            }
                            UnityStudio.LoadBundleFile(abPath,true,savePath);
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Unrecognized command:");
            for(int i=0;i<args.Length;i++){
                Console.WriteLine("CMD["+i+"]="+args[i].ToString());
            }
        }
    }
}