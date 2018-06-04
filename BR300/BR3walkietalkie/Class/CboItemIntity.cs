namespace BR300walkietalkie.Class
{
    /// <summary>
    /// 字典
    /// </summary>
    public class CboItemIntity
    {
        private object _text = 0;
        private object _Value = "";
        /// <summary>
        /// 显示值
        /// </summary>
        public object Text
        {
            get { return this._text; }
            set { this._text = value; }
        }
        /// <summary>
        /// 对象值
        /// </summary>
        public object Value
        {
            get { return this._Value; }
            set { this._Value = value; }
        }

        public override string ToString()
        {
            return this.Text.ToString();
        }
        /// <summary>
        /// 创建Item
        /// </summary>
        /// <param name="text">显示值</param>
        /// <param name="value">内值</param>
        public CboItemIntity(object text, object value)
        {
            this._text = text;
            this._Value = value;
        }
    }
}
