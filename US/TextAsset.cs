using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Unity_Studio
{
    class TextAsset
    {
        public string m_Name;
        public byte[] m_Script;

        public TextAsset(AssetPreloadData preloadData, bool readSwitch)
        {
            var sourceFile = preloadData.sourceFile;
            var a_Stream = preloadData.sourceFile.a_Stream;
            a_Stream.Position = preloadData.Offset;

            if (sourceFile.platform == -2)
            {
                uint m_ObjectHideFlags = a_Stream.ReadUInt32();
                PPtr m_PrefabParentObject = sourceFile.ReadPPtr();
                PPtr m_PrefabInternal = sourceFile.ReadPPtr();
            }

            m_Name = a_Stream.ReadAlignedString(a_Stream.ReadInt32());

            if (readSwitch)
            {
                if (false){ //Using preview structure instead of raw content
                    var str1 = preloadData.ViewStruct();
                    if (str1 == null)
                        m_Script = Encoding.UTF8.GetBytes("Serialized Shader can't be read");
                    else
                        m_Script = Encoding.UTF8.GetBytes(str1);
                }else{
                    m_Script = a_Stream.ReadBytes(a_Stream.ReadInt32());
                }
            }
            else
            {
                preloadData.extension = ".txt";
                preloadData.Text = m_Name;
            }
        }
    }
}
