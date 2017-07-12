using UnityEngine;

namespace Assets
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            Debug.Log("awd");

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log(collision.collider.gameObject.tag);
            if (collision.collider.gameObject.tag == "Player")
            {
                Physics2D.IgnoreCollision(collision.collider,this.GetComponent<CircleCollider2D>());
            }
        }

        void Update()
        {
            if (Input.GetButton("Horizontal"))
            {
                var body=this.GetComponent<Rigidbody2D>();
                var x = body.transform.position.x + (2 * Input.GetAxis("Horizontal"));
                Vector3 target=new Vector3(body.transform.position.x + (12 * Input.GetAxis("Horizontal")), body.transform.position.y,0);
                transform.position = Vector3.Lerp(body.transform.position, target, Time.deltaTime);
            }
        }
    }
}