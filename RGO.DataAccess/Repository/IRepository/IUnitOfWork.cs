using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {

        IGroup_TypeRepository Group_Type { get; }
        IGroupRepository Group { get; }

        IEvidence_TypeRepository Evidence_Type { get; }
        IEvidenceRepository Evidence { get; }

        IPersonRepository Person { get; }

        IRGO_TypeRepository RGO_Type { get; }
        IRGOutputRepository RGOutput { get; }

        IRGO_Dataset_TemplateRepository RGO_Dataset_Template { get; }

        IRGO_Column_TemplateRepository RGO_Column_Template { get; }

        IRGO_DatasetRepository RGO_Dataset { get; }
        IRGO_RecordRepository RGO_Record { get; }
        IRGO_ColumnRepository RGO_Column { get; }

        IRGO_EvidenceRepository RGO_Evidence { get; }
        IRGO_ReIdentificationConfigurationRepository RGO_ReIdentificationConfiguration { get;}


        IRGO_Record_PersonRepository RGO_Record_Person { get; }
        void Save();
    }
}
