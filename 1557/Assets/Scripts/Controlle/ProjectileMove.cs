using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

    private void OnCollisionEnter(Collision collision)
    {       //벽에 충돌시 파괴
        if(collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
            //몬스터에 충돌시
        if (collision.gameObject.tag == "Monster")
        {
            //몬스터에게 데미지를 주고 사라진다.
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)        //Trigger 함수
    {       //벽에 충돌시 파괴
        if (other.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        //몬스터에 충돌시
        if (other.gameObject.tag == "Monster")
        {
            //몬스터에게 데미지를 주고 사라진다.
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        //시간대비 이동 량 float 값으로 선언
        float moveAmount = 3 * Time.fixedDeltaTime;
        //launchDirection 방향으로 발사체 이동 (Translate) 이동 시키는 함수
        transform.Translate(launchDirection * moveAmount);
    }
}
