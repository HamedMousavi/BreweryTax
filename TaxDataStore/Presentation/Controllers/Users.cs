﻿using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controllers
{

    public class Users
    {

        private static FrmLogin frmLogin;
        private static ProgramContext program;


        internal static void DisplayLoginWindow(ProgramContext programContext)
        {
            program = programContext;

            if (frmLogin == null)
            {
                frmLogin = new FrmLogin();
                frmLogin.FormClosed += new FormClosedEventHandler(OnLoginFormClosed);
            }

            frmLogin.Show();
        }


        static void OnLoginFormClosed(object sender, FormClosedEventArgs e)
        {
            program.EndAuthenticate(frmLogin.DialogResult == DialogResult.OK);
        }


        public static void Settings()
        {/*
            using (FrmAppSettings frm = new FrmAppSettings())
            {
                frm.ShowDialog();
            }*/
        }


        public static void Presence()
        {
        }


        internal static void Edit(Entities.User user)
        {
            using (FrmUserEditor frm = new FrmUserEditor(user))
            {
                frm.ShowDialog();
            }
        }


        internal static void Delete(Entities.User user)
        {
            DomainModel.Membership.Users.Delete(user);
        }


        internal static void ToggleEnabled(Entities.User user)
        {
            user.IsEnabled = !user.IsEnabled;
            DomainModel.Membership.Users.Save(user);
        }


        internal static bool AddNew()
        {
            using (FrmUserEditor frm = new FrmUserEditor())
            {
                return (frm.ShowDialog() == DialogResult.OK);
            }
        }
    }
}
