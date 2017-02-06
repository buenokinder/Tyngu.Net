using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyngu.Net.Core;
using Tyngu.Net.Core.Attribute;
using Tyngu.Net.V1.Intefaces;

namespace Tyngu.Net.V1
{

    public class TynguRepository<T, U> : BaseClient, ITynguRepository<T, U>
        where T : ITynguModel
        where U : ITynguModel
    {
        private JsonSerializerSettings _jsonSettings;
        protected override JsonSerializerSettings JsonSettings
        {
            get
            {
                if (_jsonSettings == null)
                {
                    _jsonSettings = new JsonSerializerSettings();
                    _jsonSettings.Converters.Add(new StringEnumConverter());
                    _jsonSettings.Formatting = Formatting.Indented;
                    _jsonSettings.ContractResolver = new TynguContractResolver();
                    _jsonSettings.NullValueHandling = NullValueHandling.Ignore;
                }
                return _jsonSettings;
            }
        }
        public TynguRepository(Uri apiAddress, string apiToken, string apiKey) : base(apiAddress, apiToken, apiKey) { }


        public string GetPathFromAttribute()
        {
            System.Reflection.MemberInfo info = typeof(T);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i] is ApiPath)
                    return ((ApiPath)attributes[i]).Path;
            }
            return string.Empty;

        }
        protected override Uri PathToUri(string path, string query = null)
        {
            return base.PathToUri(GetPath(path), query);
        }

        private static string GetPath(string path)
        {
            return  path;
        }
        public Response Create(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Entidade nula!");

            return base.DoRequest<Response>(PathToUri(GetPathFromAttribute()), "POST", ToJson(entity));
        }

        public T Get(string code)
        {
            return base.DoRequest<T>(PathToUri(GetPathFromAttribute() + "/" + code));
        }

        public void SetActive(string code, bool active)
        {
            string uri = string.Format("{0}/{1}/", GetPathFromAttribute(), code);

            if (active)
                uri += "activate";
            else
                uri += "inactive";

            DoRequest(PathToUri(uri), "PUT");
        }


        public void Update(string code, T entity)
        {
            if (string.IsNullOrEmpty(code))
                throw new ArgumentNullException("code");

            if (entity == null)
                throw new ArgumentNullException("plan");

            //Limpa o código para não dar conflito com o que foi passado
            //dynamic newEntity = entity;
            //newEntity.Code = null;

            base.DoRequest(PathToUri(GetPathFromAttribute() + "/" + code), "PUT", ToJson(entity));
        }


        public U GetAll()
        {
            return base.DoRequest<U>(PathToUri(GetPathFromAttribute()));
        }
    }
}
