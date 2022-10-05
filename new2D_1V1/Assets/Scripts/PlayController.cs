using UnityEngine;


namespace bailey
{
    /// <summary>
    /// 玩家的2D控制器
    /// </summary>

    public class PlayController : MonoBehaviour
    {
        #region 資料 : Field

        [SerializeField, Header("移動速度"), Range(0, 10f)]
        private float speed = 3.5f;
        
        [Header("圖片:上中下")]
        [SerializeField]private Sprite spriteUp;
        [SerializeField]private Sprite spriteMid;
        [SerializeField]private Sprite spriteDown;

        private SpriteRenderer spr;
        private Rigidbody2D rig;
        #endregion

        #region 事件
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

        #region 方法

        /// <summary>
        /// 移動
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");  //A、D 
            float v = Input.GetAxis("Vertical");    //W、S

            rig.velocity = new Vector2(h, v) * speed;

            if (v > 0) spr.sprite = spriteUp;
            else if (v < 0) spr.sprite = spriteDown;
            else spr.sprite = spriteMid;
            
        }

    
        #endregion
    }

}

