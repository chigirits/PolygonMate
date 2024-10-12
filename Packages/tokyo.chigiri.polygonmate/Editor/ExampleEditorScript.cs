using UnityEditor;

namespace tokyo.chigiri.polygonmate.editor
{

    public class ExampleEditorScript
    {
        [MenuItem("Tools/PolygonMate/Test")]
        static void Test()
        {
            EditorUtility.DisplayDialog("Example Script", "Opened This Dialog", "OK");
        }
    }

}
