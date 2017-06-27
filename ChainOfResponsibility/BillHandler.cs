using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 单据处理角色
    /// </summary>
    public abstract class BillHandler
    {
        /// <summary>
        /// 单据处理者姓名
        /// </summary>
        public string UserName { get; set; }  
        /// <summary>
        /// 单据处理者具有的权限
        /// </summary>
        public List<string> Permissions { get; set; }

        public bool CheckPermission(string permission)
        {
            return Permissions.Contains(permission);
        }

        /// <summary>
        /// 下一个处理者
        /// </summary>
        public BillHandler Successor { get; set; }

        public void HandleBill(Bill bill)
        {
            //单据处理从保存开始
            if(CheckPermission("SAVE")&&bill.Status==BillStatus.Open)
            {
                this.DoBillOperation(bill);
            }
            else
            {
                this.Successor.DoBillOperation(bill);
            }
        }

        public abstract void DoBillOperation(Bill bill);

    }

    public class Purchaser:BillHandler
    {
        private List<string> permissions = new List<string>() { "SAVE" };

        public Purchaser(string userName)
        {
            base.UserName = userName;
            base.Permissions = permissions;
            base.Successor = new Manager("经理-x");//在构造函数中指定下一个处理者
        }

        public override void DoBillOperation(Bill bill)
        {
            if (CheckPermission("SAVE") && bill.Status == BillStatus.Open)
            {
                bill.Status = BillStatus.Saved;
                Console.WriteLine($"{UserName}{bill.BilNo}已经保存");
            }
            if (CheckPermission("SUBMIT") && bill.Status == BillStatus.Saved)
            {
                bill.Status = BillStatus.Submitted;
                Console.WriteLine(string.Format("{0}：{1}已经提交！", this.UserName, bill.BilNo));
            }
        }
    }

    public class Manager : BillHandler
    {
        public Manager(string userName)
        {

        }
        public override void DoBillOperation(Bill bill)
        {
            throw new NotImplementedException();
        }
    }

    public class CEO : BillHandler
    {
        public CEO(string userName)
        {

        }
        public override void DoBillOperation(Bill bill)
        {
            throw new NotImplementedException();
        }
    }
}
