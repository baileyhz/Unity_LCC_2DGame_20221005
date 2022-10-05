using UnityEngine;


namespace bailey
{
    /// <summary>
    /// ���a��2D���
    /// </summary>

    public class PlayController : MonoBehaviour
    {
        #region ��� : Field

        [SerializeField, Header("���ʳt��"), Range(0, 10f)]
        private float speed = 3.5f;
        
        [Header("�Ϥ�:�W���U")]
        [SerializeField]private Sprite spriteUp;
        [SerializeField]private Sprite spriteMid;
        [SerializeField]private Sprite spriteDown;

        private SpriteRenderer spr;
        private Rigidbody2D rig;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
            spr = GetComponent<SpriteRenderer>();
        }


        private void Update()
        {
            Move();
        }

        #endregion

        #region ��k

        /// <summary>
        /// ����
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");  //A�BD 
            float v = Input.GetAxis("Vertical");    //W�BS

            rig.velocity = new Vector2(h, v) * speed;

            if (v > 0) spr.sprite = spriteUp;
            else if (v < 0) spr.sprite = spriteDown;
            else spr.sprite = spriteMid;
            
        }

    
        #endregion
    }

}

