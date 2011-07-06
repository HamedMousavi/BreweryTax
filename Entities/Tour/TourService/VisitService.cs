using Entities.Abstract;


namespace Entities
{

    public class VisitService : TourServiceBase
    {

        protected GeneralType visitType;

        public override string Name
        {
            get { return this.visitType.Name; }
        }


        public GeneralType VisitType
        {
            get
            {
                return this.visitType;
            }

            set
            {
                if (this.visitType != value)
                {
                    this.visitType = value;
                    RaisePropertyChanged("VisitType");
                }
            }
        }


        public VisitService()
        {
            this.visitType = new GeneralType();
        }


        public override ITourService Clone()
        {
            VisitService service = new VisitService();
            CopyTo(service);
            this.visitType.CopyTo(service.visitType);
            service.IsDirty = this.IsDirty;

            return service;
        }
    }
}
