using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTileMap : MonoBehaviour
{
    public GameObject tile_001;                                                  //������ �������� ����Ƽ �ν����� â���� �Է� �޴´�.
    // Start is called before the first frame update
    void Start()
    {
        for(int i= 0; i < 20; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile_001);            //instantiate �Լ��� Prefebs�� �����ϴ� �Լ� return �ִ�. (temp�� �Է�)
                temp.transform.position = new Vector3(i, 0, j);                 //temp �Է¹��� ������Ʈ�� ��ġ ���� (x => i �̰� z => j) �̴�.
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
