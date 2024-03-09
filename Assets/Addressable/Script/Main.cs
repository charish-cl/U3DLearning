using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Threading.Tasks;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    void Start()
    {
        // InstantiateCube();
        LoadScene();
       // LoadServerResouses();
    }
	
    private async void InstantiateCube()
    {
        // 虽然这里使用了Task，但并没有使用多线程
        GameObject prefabObj = await Addressables.LoadAssetAsync<GameObject>("Assets/Addressable/Square.prefab").Task;
        // 实例化
        GameObject square = Instantiate(prefabObj);
		
        // 也可直接使用InstantiateAsync方法
        // GameObject cubeObj = await Addressables.InstantiateAsync("Assets/Prefabs/Cube.prefab").Task;
    }

    public RawImage img;
    public async void LoadServerResouses()
    {

        var obj = await Addressables.LoadAssetAsync<Texture2D>("Assets/Addressable/84808352_p0_master1200.jpg").Task;

        // 图片
        Texture2D tex2D = obj;
        img.texture = tex2D;
        img.GetComponent<RectTransform>().sizeDelta = new Vector2(tex2D.width, tex2D.height);
    }

    public async void LoadScene()
    {
        var sceneAsync = await Addressables.LoadSceneAsync("Assets/Addressable/TestScene.unity").Task;
        Addressables.UnloadSceneAsync(sceneAsync);
    }
}