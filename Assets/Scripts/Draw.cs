using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    Camera cam;
    Color32[] brushColors;

    public MeshRenderer meshRenderer;//Boyayacagimiz obje
    public Texture2D brush;//Firca texture'i
    public Vector2Int textureArea;//x:1024, y:1024
    Texture2D texture;  

    private void Start()
    {
        texture = new Texture2D(textureArea.x, textureArea.y, TextureFormat.ARGB32, false);
        meshRenderer.material.mainTexture = texture;
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) //Sol tika basili tuttukca boyayacak
        {
            RaycastHit hitInfo;
            //cam, kullandigimiz kamera (Camera classi)
            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {
                //Debug.Log(hitInfo.textureCoord); //0-1 arasinda UV koordinati
                Paint(hitInfo.textureCoord);
            }
        }
    }

    private void Paint(Vector2 coordinate)
    {
        coordinate.x *= texture.width;//0-1 degerini tam nokta piksellere cevirdik
        coordinate.y *= texture.height;//Yani 0-1024 yaptik
        Color32[] textureC32 = texture.GetPixels32();
        Color32[] brushC32 = brush.GetPixels32();

        //Fircanin ortasinin koordinatlari, kare firca ise float da olabilir
        Vector2Int halfBrush = new Vector2Int(brush.width / 2, brush.height / 2);

        /*for (int x = 0; x < brush.width; x++)
        {
            int xPos = x - halfBrush.x + (int)coordinate.x;
            for (int y = 0; y < brush.height; y++)
            {
                int yPos = y - halfBrush.y + (int)coordinate.y;
                if (brush.GetPixel(x, y).a != 0)
                {
                    if (texture.GetPixel(xPos, yPos).r > brush.GetPixel(x, y).r)
                    {
                        texture.SetPixel(xPos, yPos, brush.GetPixel(x, y));
                    }
                }
            }
        }*/

        for (int x = 0; x < brush.width; x++)
        {
            int xPos = x - halfBrush.x + (int)coordinate.x;
            if (xPos < 0 || xPos >= texture.width)
                continue;
            for (int y = 0; y < brush.height; y++)
            {
                int yPos = y - halfBrush.y + (int)coordinate.y;
                if (yPos < 0 || yPos >= texture.height)
                    continue;
                if (brushC32[x + (y * brush.width)].a > 0f)
                {
                    int tPos =
                        xPos + //X (U) posizyonu
                        (texture.width * yPos); //Y (V) Posizyonu

                    if(brushC32[x + (y * brush.width)].r < textureC32[tPos].r)
                        textureC32[tPos] = brushC32[x + (y * brush.width)];
                }
            }
        }

        texture.SetPixels32(textureC32);//Array'i set ettik
        texture.Apply();//Degişikliklerin uygulanmasi icin
    }



/*for (int x = 0; x < brush.width; x++)
{
    int xPos = x - halfBrush.x + (int)coordinate.x;
    if (xPos < 0 || xPos >= textureArea.x)
        continue;
    for (int y = 0; y < brush.height; y++)
    {
        int yPos = y - halfBrush.y + (int)coordinate.y;
        if (yPos < 0 || yPos >= textureArea.y)
            continue;
        if (brushC32[x + (y * brush.width)].a == 0)
            continue;

        int texPoint = xPos + (textureArea.x * yPos);
        if(brushC32[x + (y * brush.width)].r < textureC32[texPoint].r)
            textureC32[texPoint] = brushC32[x + (y * brush.width)];
    }
}*/

/*     private LineRenderer line;
    private Vector3 previousPosition;
    [SerializeField]
    private float minDistance = 0.1f;
    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 1;
        previousPosition = transform.position;    
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;

            if(Vector3.Distance(currentPosition, previousPosition) > minDistance)
            {
                if(previousPosition == transform.position)
                {
                    line.SetPosition(0, currentPosition);
                }
                else
                {
                    line.positionCount++;
                    line.SetPosition(line.positionCount - 1, currentPosition);
                }

                previousPosition = currentPosition;
            }
        }
    } */
}
