using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public  class sickroom
    {
        
        /// <summary>
        /// --病房号
        /// </summary>
        public int Idsickroom  { get; set; } //--病房号
        /// <summary>
        /// --科别
        /// </summary>
        public int Sid	{ get; set; }          //--科别
        /// <summary>
        /// --病房类型
        /// </summary>
        public string  Tyep	 { get; set; }           //--病房类型 
        /// <summary>
        /// --价格
        /// </summary>
        public int Price { get; set; }             //--价格
    }
}
