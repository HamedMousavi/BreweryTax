using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Security.AccessControl;
using System.Security.Principal;


namespace DomainModel.Repository.Sql
{

    public static class Utils
    {

        internal static void EnsureDirectoryExists(string directoryPath)
        {
            if (!System.IO.Directory.Exists(directoryPath))
            {
                SecurityIdentifier sid = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
                NTAccount acct = sid.Translate(typeof(NTAccount)) as NTAccount;
                string everyoneAccount = acct.ToString();
                //System.Security.Principal.WindowsIdentity.GetCurrent().Name,

                FileSystemAccessRule fsr = new
                    FileSystemAccessRule(
                        everyoneAccount,
                        FileSystemRights.Modify,
                        InheritanceFlags.None,
                        PropagationFlags.InheritOnly,
                        AccessControlType.Allow
                    );

                DirectorySecurity ds = new DirectorySecurity();
                ds.AddAccessRule(fsr);

                System.IO.Directory.CreateDirectory(
                    directoryPath,
                    ds);
            }
        }


        public static string GetSafeString(SqlDataReader reader, string fieldName)
        {
            try
            {
                object objDbVal = reader[fieldName];
                if (DBNull.Value != objDbVal && null != objDbVal)
                {
                    return Convert.ToString(objDbVal, CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {/*
                ApplicationState.Instance.Controller.UpdateStatus(
                    new StatusController.Entities.StatusInfo(
                    (Int16)StatusCodes.Assemblies.Codes.DomainModel,
                    (Int16)StatusCodes.Sections.Codes.Repository,
                    StatusController.Abstract.StatusTypes.Error,
                    (Int32)StatusCodes.Errors.Codes.General,
                    null, ex.ToString()));*/
            }

            return string.Empty;
        }


        public static int GetSafeInt32(SqlDataReader reader, string fieldName)
        {
            try
            {
                object objDbVal = reader[fieldName];
                if (objDbVal != DBNull.Value && null != objDbVal)
                {
                    return Convert.ToInt32(objDbVal, CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {/*
                ApplicationState.Instance.Controller.UpdateStatus(
                    new StatusController.Entities.StatusInfo(
                    (Int16)StatusCodes.Assemblies.Codes.DomainModel,
                    (Int16)StatusCodes.Sections.Codes.Repository,
                    StatusController.Abstract.StatusTypes.Error,
                    (Int32)StatusCodes.Errors.Codes.General,
                    null, ex.ToString()));*/
            }

            return 0;
        }


        public static DateTime GetSafeDateTime(SqlDataReader reader, string fieldName, DateTime defaultVal)
        {
            try
            {
                object objDateTime = reader[fieldName];

                if (objDateTime == null ||
                    objDateTime == DBNull.Value)
                {
                    return defaultVal;
                }

                defaultVal = Convert.ToDateTime(objDateTime, CultureInfo.InvariantCulture);
                return defaultVal;//.ToLocalTime();
            }
            catch (Exception ex)
            {/*
                ApplicationState.Instance.Controller.UpdateStatus(
                    new StatusController.Entities.StatusInfo(
                    (Int16)StatusCodes.Assemblies.Codes.DomainModel,
                    (Int16)StatusCodes.Sections.Codes.Repository,
                    StatusController.Abstract.StatusTypes.Error,
                    (Int32)StatusCodes.Errors.Codes.General,
                    null, ex.ToString()));*/
            }

            return defaultVal;
        }


        internal static bool GetSafeBoolean(SqlDataReader reader, string fieldName)
        {
            try
            {
                object objDbVal = reader[fieldName];
                if (DBNull.Value != objDbVal && null != objDbVal)
                {
                    return Convert.ToBoolean(objDbVal, CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {/*
                ApplicationState.Instance.Controller.UpdateStatus(
                    new StatusController.Entities.StatusInfo(
                    (Int16)StatusCodes.Assemblies.Codes.DomainModel,
                    (Int16)StatusCodes.Sections.Codes.Repository,
                    StatusController.Abstract.StatusTypes.Error,
                    (Int32)StatusCodes.Errors.Codes.General,
                    null, ex.ToString()));*/
            }

            return false;
        }


        internal static decimal GetSafeDecimal(SqlDataReader reader, string fieldName)
        {
            try
            {
                object objDbVal = reader[fieldName];
                if (objDbVal != DBNull.Value && null != objDbVal)
                {
                    return Convert.ToDecimal(objDbVal, CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {/*
                ApplicationState.Instance.Controller.UpdateStatus(
                    new StatusController.Entities.StatusInfo(
                    (Int16)StatusCodes.Assemblies.Codes.DomainModel,
                    (Int16)StatusCodes.Sections.Codes.Repository,
                    StatusController.Abstract.StatusTypes.Error,
                    (Int32)StatusCodes.Errors.Codes.General,
                    null, ex.ToString()));*/
            }

            return 0.0m;
        }


        internal static object GetDbTime(DateTime dateTime)
        {
            return dateTime;
        }
    }

}
