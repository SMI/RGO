-- Group Type
INSERT INTO public."Group_Types" ("Name", "Created_Date")
VALUES('Research Group',NOW())
-- RGOType
INSERT INTO public."RGO_Types" ("Name", "Created_Date")
VALUES('Image Labelling',NOW())
-- Release Statuses
INSERT INTO public."RGO_Release_Statuses" ("Name", "Available_For_Release","Created_Date")
VALUES('Released','Y',NOW())
INSERT INTO public."RGO_Release_Statuses" ("Name", "Available_For_Release","Created_Date")
VALUES('No','N',NOW())
INSERT INTO public."RGO_Release_Statuses" ("Name", "Available_For_Release","Created_Date")
VALUES('Yes, with Conditions','M',NOW())
-- Group
INSERT INTO public."Groups" ("Name", "Created_Date", "Group_TypeId")
VALUES('Brain Health Hub',NOW(),1)
-- RG Output
INSERT INTO public."RGOutputs" ("Name", "Created_Date", "RGO_TypeId","Originating_GroupId")
VALUES('MRI Labelling',NOW(),1,1)
-- Dataset Template
INSERT INTO public."RGO_Dataset_Templates" ("Name", "Created_Date","RGOutput_Id","Release_Status_Id")
VALUES('MRI Labelling',NOW(),2,1)
-- Coulmn Template
INSERT INTO public."RGO_Column_Templates"("RGO_Dataset_TemplateId","Name","PK_Column_Order","Type","Potentially_Disclosive","Created_Date","IsIdentifier","Release_Status_Id")
VALUES(4,'Image_Identifier',1,'Char','N',Now(),0,1)
INSERT INTO public."RGO_Column_Templates"("RGO_Dataset_TemplateId","Name","PK_Column_Order","Type","Potentially_Disclosive","Created_Date","IsIdentifier","Release_Status_Id")
VALUES(4,'MRI_Classification_consensus',1,'int','N',Now(),0,1)
