using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProposalManageSystem.Models.Bean {
    public class PageAbout {
        private string title;
        private string foot;
        private List<string> menuList;
        private string userName;

        public void setTitle (string title) {
            this.title = title;
        }
        public string getTitle () {
            return title;
        }
        public void setFoot (string foot) {
            this.foot = foot;
        }
        public string getFoot () {
            return foot;
        }
        public void setMenuName (List<string> menuList) {
            this.menuList = menuList;
        }
        public List<string> getMenuName () {
            return menuList;
        }
        public void setUserName (string userName ) {
            this.userName = userName;
        }
        public string getUserName () {
            return userName;
        }
         
    }
}