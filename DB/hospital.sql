--drop  database hospitals

create database hospitals

go

use hospitals

go
--+++++++++++++++++++++++++++++++++++++++++++++++++1++++++++++++++++++++
create table IdCard                         		  --���ű�     *************
(
  KId        	int identity(10000,1)   primary key,    		 --����
  Name       	varchar(20),                		             --����
  Sex        	char(2),                    		                     --�Ա�
  Age        	int ,					    	            	     --����
  Birthday   	smalldatetime,              		        --��������
  Address    	varchar(50),						           --��ַ
  Phone     	char(11),										   --�绰
  Nation		varchar(20),									 --����
  Cultrue       varchar(20),									 --�Ļ�
  Marriage      char(4),                   			 		 --����״��
  Work          varchar(10),                				 --ְҵ
  Postcode      varchar(6),                 				 --�ʱ�  
  IdcardNo      varchar(18)             			    	--���֤����
)
--drop table IdCard
insert IdCard values('����','Ů',12,'2004-10-04','awefa','13456789023','��','�Ļ�','δ��','��ҵ','519000','362502199303102655')
insert IdCard values('�Ǻ�','��',19,'2005-11-08','�Ǻ�','13456789023','��','�Ļ�','�ѻ�','��ʦ','519000','362502199303102655')
insert IdCard values('�ٺ�','Ů',18,'2004-12-11','����','13456789023','��','��ѧ','δ��','����','344410','362502199303102655')
insert IdCard values('����','��',24,'2004-12-11','����','13456789023','����','����','�ѻ�','����','344410','362502199303102655')
insert IdCard values('����','Ů',20,'2004-10-04','����͢','13456789023','��','��ѧ','δ��','��ҵ','519000','362502199303102655')
insert IdCard values('���Ƿ�','��',19,'2005-11-08','����','13456789023','����','Сѧ','�ѻ�','��ҵ','519000','362502199303102655')
insert IdCard values('ŷ��','Ů',18,'2004-12-11','Ӣ��','13456789023','��','��ר','δ��','����','344410','362502199303102655')
insert IdCard values('Ľ��','��',24,'2004-12-11','����˹','13456789023','����','˶ʿ','�ѻ�','����','344410','362502199303102655')
go

create proc Reg_IdCard
@Name varchar(20), @Sex char(2), @Age int, @Birthday smalldatetime, @Address varchar(50), @Phone char(11), 
@Nation varchar(20), @Cultrue varchar(20), @Marriage char(4), @Work varchar(6), @Postcode varchar(6), 
@IdcardNo varchar(18), @result int output
as
	if(select COUNT(*) from IdCard where IdcardNo=@IdcardNo)=0
	begin
		insert IdCard values(@Name, @Sex, @Age, @Birthday, @Address, @Phone, @Nation, @Cultrue, @Marriage, @Work,
		@Postcode, @IdcardNo)
		set @result = 1
	end
	else 
		set @result = 0

go		
create proc p_IdCard_select
as
  select * from IdCard
  
 go
create proc p_IdCard_select1
as
  select * from IdCard
  
 go
 create proc IdCard_S_select
@kid int
as
	select Name , sex, age, address from IdCard where KId=@kid

--+++++++++++++++++++++++++++++++++++++++++++++++2++++++++++++++++++++++
go
create table register                                --�Һű�
(
  Rid       	        varchar(10) primary key ,    --�ҵ���
  KId       			int ,                            --����
  IdType    			varchar(10),                 --����
  GuaDanFei     		int,                         --�ҵ���
  OtherFei      		int,                         --������ 
  SectionRoom   		varchar(10),                 --����
  Doctor        		varchar(10),                 --ҽʦ
  ReristerTime  		smalldatetime,               --�Һ�����
  SeeDoctorTime 		smalldatetime                --��������
)
--select * from register
--drop table register 

go
create proc p_retister_insert
@Rid varchar(10),
@Kid int,
@IdType varchar(10),
@GuaDanFei int,
@OtherFei  int,
@SectionRoom varchar(10),
@Doctor      varchar(10),
@ReristerTime smalldatetime,
@SeeDoctorTime smalldatetime,
@mess varchar(10) output
as
    if (select count(*) from register where Rid=@Rid or Kid=@Kid)=0 and (select COUNT(*) from IdCard where @Kid=KId)=1
    begin
    insert register values( @Rid,@Kid,@IdType, @GuaDanFei,@OtherFei,@SectionRoom,@Doctor,@ReristerTime,@SeeDoctorTime)
    set @mess ='�Һųɹ�'
    end
    else
    set @mess='�˿��ѹҺ�'

    select * from register

go
 declare @mess varchar(10)
 exec p_retister_insert '0002', 10001,'��ͨ��',10,5,'���','����','2012-04-09','2012-04-13',@mess output 
 select @mess

 
--+++++++++++++++++++++++++++++++++++++++++++++++3++++++++++++++++++++++
go
create table users                                   --�û���
(
  Uid				 int identity(1000,1) primary key,     		--�û����     
  Uname        varchar(10),                 							--�û���
  name          varchar (10),     ---�û�����
  Pwd		     varchar(10),                 						   --����    
  Sex				 char(2),											    --�Ա�
  Address        varchar(20),										     --��ַ
  Phone          char(11),												 --��ϵ�绰 
  Spell			  varchar(10),										   --ƴ����
 
  Type			  varchar(20),										    --����
   SectionRoom  varchar(10),                                      --����
  money		  int ,													  --�Һŷ�
  Peodom       varchar(500),									    --Ȩ��             
)


select * from users
go
insert users  values('admin','�����','123','��','�麣','13697777241','adimin','����Ա', '',0,'-ϵͳ����-Ȩ�޹���-')
go
create proc  p_users_delete 
@Uid int 
as 
	delete users  where Uid =@Uid 
	
	
select * from users
go
create proc p_peodom_select
@Uname varchar(10)
as
	select users.Peodom ,usersType .Peodom    from  users join usersType  on users.Type=usersType.Type  where Uname=@Uname

go
create proc p_usersPeodom_update
@Uname varchar(20),
@peodom varchar(500)
as
	update users  set  Peodom =@peodom  where Uname = @Uname 

--drop table users
go
create proc p_users_select01 
as
	select * from users 

go
create proc p_users_insert 
@Uname        varchar(10),									--�û���
@name          varchar (10),
@Pwd          varchar(10),									   --����    
@Sex          char(2),                                              --�Ա�
@Address      varchar(20),										 --��ַ
@Phone        char(11),											 --��ϵ�绰
@Spell        varchar(10),										--ƴ����
@Type         varchar(20),								     --����
@SectionRoom varchar(10),
@money      int,                              					 --�Һŷ�	
@Peodom       varchar(500),								 --Ȩ��   
@result       varchar(20) output								   
as
    if (select COUNT(*) from users where Uname=@Uname)=0
        begin 
          insert users values(@Uname,@name,@Pwd,@Sex,@Address,@Phone, @Spell, @Type,@SectionRoom,@money,@Peodom)
           set @result = '��ӳɹ�'
         end
         else
           set @result = '�û����Ѿ�����'

 select * from users   

--****************************************************************************************************** 


go
create table usersType   --���ͱ�
(
	Tid  int  identity(1,1) primary key,
    Type         varchar(20), 
    Peodom       varchar(500)   
)
insert  usersType values('����Ա','ϵͳ����-Ȩ������' )

go
create  proc p_usesType_update
@Type varchar(20),
@peodom varchar(500)
as
	update usersType  set  Peodom =@peodom  where Type = @Type 


go
create proc p_usesType_delete 
@Type varchar(20)
as
	delete usersType  where @Type =Type 

go
create proc p_usesType_select
as	
	select * from usersType


go
create  proc p_usersType_insert--------------------------------------------------
@Type varchar(20),
@peodom varchar(500),
@mess varchar(20) output
as 
  if (select COUNT(*) from usersType where @Type=Type )=0
  begin
		insert usersType  values(@Type ,@peodom )
		 set @mess='��ӳɹ���'
 end
  else 
    set @mess='�������Դ��ڣ�'
   
    
   


go
create proc [dbo].[p_users_select]
@Uname   varchar(10),
@Pwd     varchar(10),
@return  int output
as 
    if(select COUNT(*) from users where Uname=@Uname )=0
        set @return=0
     else   if(select COUNT(*) from users where Uname=@Uname and Pwd=@Pwd) = 0
       set @return=1   
       
    else
       set @return=2
       

 
--++++++++++++++++++++++++++++++++++++++++++++++++4+++++++++++++++++++++

go
create table nurse                                	--��ʿ��
(
    Nid int identity (1,1) primary key,           	--��ʿ���
    Name varchar(10),                             	--��ʿ��
    Type varchar(10)                              	--����
    
)


--++++++++++++++++++++++++++++++++++++++++++++++++4+++++++++++++++++++++

go

create  table  SectionRoom                 			--���ұ�
(
   Sid           int   identity(1,1)    primary key,                     --���
   Sname          varchar(10) ,                      	--������
   Saddr          varchar(20) ,                      --���ҵ�ַ
   Sprice         int                               --�Һŷ� 
)
go
insert SectionRoom values('���' ,'2¥�����',5)
insert SectionRoom values('�ڿ�','3¥�ڿ���',6)
insert SectionRoom values('���˿�','4¥���˿���',10)
insert SectionRoom values('�ۿ�','2¥�ۿ���',15)
insert SectionRoom values('����','5¥������',25)
insert SectionRoom values('�����','2¥�������',15)
insert SectionRoom values('Ƥ����','3¥Ƥ������',25)
insert SectionRoom values('������','1¥��������',10)
insert SectionRoom values('��˿�','5¥��˿���',5)
insert SectionRoom values('��Ⱦ��','3¥��Ⱦ����',25)
insert SectionRoom values('�񾭿�','2¥�񾭿���',30)
insert SectionRoom values('�����','3¥�������',20)
insert SectionRoom values('����','4¥������',10)
insert SectionRoom values('��ҽ��','2¥��ҽ����',50)
insert SectionRoom values('�����ʺ��','1¥�����ʺ����',15)
insert SectionRoom values('��ǻ��','2¥��ǻ����',25)
insert SectionRoom values('����','3¥������',35)
insert SectionRoom values('����ֲ','2¥����ֲ��',25)

go
create proc p_SectionRoom_select
as
   select * from SectionRoom
  
  
  go 
create proc p_SectionRoom
@Sname         varchar(10) ,
@Saddr		   varchar(20) ,
@Sprice		   int,
@result        varchar(10) output
as
    if (select COUNT(*) from SectionRoom where  Sname=@Sname)=0
       insert SectionRoom values(@Sname,@Saddr,@Sprice) 
    else
       set @result='�˿�������'
      
     
go  
create proc p_SectionRoom_Update
@Sname         varchar(10) ,
@Saddr		   varchar(20) ,
@Sprice		   int
as
   update SectionRoom  set Saddr=@Saddr, Sprice=@Sprice where Sname=@Sname


go
create proc p_SectionRoom_delete
@Sname  varchar(10) 
as
	delete SectionRoom where @Sname=Sname


--++++++++++++++++++++++++++++++++++++++++++++++++5+++++++++++++++++++++

go
create table SectionRooomSon               			--�ӿ��ұ�
(
   SonId         int identity(1,1) primary key,
   Sname         varchar(10),                     	--������
   SonName       varchar(10)                    	--�ӿ�����
) 

go
create  proc p_SectionRooomSonDelete
@SonName	     varchar(10) ,
@result   varchar(20)  output
as
			delete SectionRooomSon where  SonName=@SonName
			set @result='ɾ���ɹ�'


go
create proc p_SectionRooomSon_select
as
	select * from SectionRooomSon
--drop table SectionRooomSon


go
create proc p_SectionRooomSonInsert
@Sname      varchar(10),
@SonName    varchar(10),
@result     varchar(20) output
as
  if(select COUNT(*) from SectionRooomSon where SonName= @SonName)=0
  begin
      insert SectionRooomSon values (@Sname,@SonName)
      
  end
  else
        set @result='���ӿ����Ѿ����'
   
  go 
  declare @result  varchar(20)
  exec p_SectionRooomSonInsert '���','�Ǻ�',@result output
  select @result






--++++++++++++++++++++++++++++++++++++++++++++++++6+++++++++++++++++++++
--select * from Drug_insert

go
create table  Drug_insert    						--ҩƷ����
(
   Dname           varchar(10),    				    --ҩƷ����
   Dtype             varchar(10),    				    --ҩƷ����
   DcostName     varchar(10),    			        --��������
   Dspec              varchar(10),                       --���  
   DjiXing            varchar(10),                       --����   
   DinsertPrice      int,            			                 --����
   DsellPrice         int,             			                --�ۼ�
   Dstock              int,            			              --���
   DstockMax        int,							          --�������
   DstockMin         int,           			             --�������
   DeffectTime     smalldatetime,                     --��Ч��
   DproductTime  smalldatetime,                     --������
   Efficay              varchar(50)                          --����Ч
)
--drop table drug_insert
go
create proc Drug_insert_p
@DName varchar(10), @Dtype varchar(10), @DcostName varchar(10), @Dspec varchar(10), @DjiXing varchar(10), @DinsertPrice int, 
@DsellPrice int, @Dstock int, @DstockMax int, @DstockMin int, @DeffectTime smalldatetime, @DproductTime smalldatetime, @Efficay varchar(50),
@result int output
as
	if(select COUNT(*) from Drug_insert where DName=@DName)=0
	begin
		insert Drug_insert values(@DName, @Dtype, @DcostName, @Dspec, @DjiXing, @DinsertPrice, @DsellPrice, @Dstock, @DstockMax, @DstockMin,
		@DeffectTime, @DproductTime, @Efficay)
		set @result = 1
	end
	else 
		set @result = 0
go

create proc Drug_update_p
@DName varchar(10), @Dtype varchar(10), @DcostName varchar(10), @Dspec varchar(10), @DjiXing varchar(10), @DinsertPrice int, 
@DsellPrice int, @Dstock int, @DstockMax int, @DstockMin int, @DeffectTime smalldatetime, @DproductTime smalldatetime, @Efficay varchar(50)
as
	update drug_insert set Dtype=@Dtype, DcostName=@DcostName,Dspec= @Dspec, DjiXing=@DjiXing, DinsertPrice=@DinsertPrice, 
	DsellPrice=@DsellPrice, Dstock=@Dstock, DstockMax=@DstockMax, DstockMin=@DstockMin,DeffectTime=@DeffectTime, DproductTime=@DproductTime, 
	Efficay=@Efficay where Dname=@DName

go
create  proc Drug_SelectName_p
@DName varchar(10)
as
	select * from drug_insert where DName Like '%'+@DName+'%'
	
	--exec Drug_SelectName_p @DName='21'
	
go	
create proc Drug_Delete_p
@DName varchar(10)
as
  delete drug_insert where @DName=DName

 --++++++++++++++++++++++++++++++++++++++++++++++++7+++++++++++++++++++++

go
create table sickroom  --������
(
    Idsickroom  int  primary key,         --������
    Sid				int,                             --�Ʊ�
    Tyep				 varchar(10),                              --�������� 
    Price					 int                             --�۸�
)



select * from sickroom  

go
 create  proc p_sickroom_insert --��Ӳ���
@Idsickroom int ,
@Sid int,
@Type varchar(10),
@Price int,
@result varchar(30) output
as
    if(select  COUNT(*) from sickroom  where @Idsickroom=Idsickroom)=0
    begin
			  insert sickroom values(@Idsickroom, @Sid,@Type,@Price)
			  set @result ='OK'
    end
    else
			  set @result='@Idsickroom   ����һ������ͬ'
	
	
go		  
create proc p_sickroom_select  --��ѯ����
as
	select * from sickroom
	
go
create proc p_sickroom_Delete
@Idsickroom int 
as
	delete sickroom where @Idsickroom=Idsickroom

 --++++++++++++++++++++++++++++++++++++++++++++++++9��λ��+++++++++++++++++++++
go


create table   bed    --��λ��
(
      Idsickroom   int,				 --������
	  Idbed           int,				 --��λ��
	  KId               int,			     --���˿���
	 State              varchar(10),      --��λ״̬
)
select * from bed

go
create proc p_bed_update
@Idsickroom int ,
@Idbed int 
as
	update bed set State='��' where @Idsickroom=Idsickroom and @Idbed=Idbed


go
 create proc p_bed_insert --��Ӳ���
@Idsickroom int ,
@Idbed int,
@KId   int,
@State varchar(10)
as
   insert bed values(@Idsickroom, @Idbed,@KId,@State)


go
create proc p_bed_select--��ѯ����
as 
   select * from bed
  
  
 go 
create proc p_bed_Delete --ɾ������
@Idsickroom int 
as
	delete bed where @Idsickroom=Idsickroom

--drop table bed

 --++++++++++++++++++++++++++++++++++++++++++++++++10����סԺ��+++++++++++++++++++++
go

create table zhuyuan  --����סԺ��
(
	kId				int ,				 --���˿���
	Sid               int,                 --����
	Idsickroom   int ,               --������
    BedNo			varchar(10),	 --��λ
    Imprest			int,				 --Ԥ����
	Bewrite			varchar(50),	 --��������
    Tabu				varchar(50),	 --ҩ�����
    Ztime              datetime   --�Ǽ�ʱ��
)

go
create proc   p_zhuyuanzhuyuanxiaofei_deleted ----סԺ��ɾ������
@kId int 
as	
    delete zhuyuan  where @kId=kId
    delete zhuyuanxiaofei   where @kId=kId


go
create proc update_zhuyuan_yujiao
@kId int ,
@Imprest int 
as
	update zhuyuan set  Imprest=@Imprest where kId=@kId


go
create  proc  p_zhuyuan_select
as		
	select zhuyuan. kId, zhuyuan.Sid ,zhuyuan.Idsickroom ,zhuyuan .BedNo ,zhuyuan .Imprest ,zhuyuan .Bewrite ,zhuyuan .Tabu ,zhuyuan.Ztime,IdCard.Name  from zhuyuan  join IdCard on zhuyuan .kId =IdCard.KId 

--drop table zhuyuan
go
create  proc p_zhuyuan_insert  --סԺ��ѯ
@kId				int ,			
@Sid               int,             
@Idsickroom   int ,            
@BedNo			varchar(10),
@Imprest			int,			
@Bewrite			varchar(50),
@Tabu				varchar(50),
@Ztime            datetime,
@result varchar(30) output
as
   if ( select  COUNT(*) from IdCard  where @kId=kId  )=1  
    begin
			if ( select  COUNT(*) from zhuyuan   where @kId=kId  ) !=0  
				 set    @result ='KO'
		   else 
		   begin 
				 insert zhuyuan values(@kId, @Sid,@Idsickroom,@BedNo, @Imprest, @Bewrite, @Tabu,@Ztime)
				update  bed set  State='ռ��' where @Idsickroom=Idsickroom and @BedNo=Idbed
 				 set @result ='OK'
		   end 
    end
   else
             set   @result ='NO'
   
     

 --++++++++++++++++++++++++++++++++++++++++++++++++11סԺ���˲�����+++++++++++++++++++++
go

create table casehistory   --סԺ���˲�����
(
	  UId					varchar(10),				--������Ա���
	  BedNo			varchar(10),				--��λ
	  UseDrug         varchar(50),				--ʹ��ҩƷ
	  Disposal          varchar(50),				--���鴦��
      Time               smalldatetime,			--���ʱ��
      Remark           varchar(50),              --��鱸ע    
)

-----*****************************
go
create table   controlinfo  ---   ���ѵ�
(
		ID int  identity(1,1) ,
	    Name  varchar(20),
		CLocation varchar(20) ,
		CFont varchar(20) ,
		CColor varchar(20),
)

-----*****************************
-----*****************************
-----*****************************

go
create table controls	 --��ӡ��Ŀ
(
	name varchar(20),
)
insert  controls values ('����')
insert  controls values ('���')
insert  controls values ('������')
insert  controls values ('��Ժʱ��')
insert  controls values ('��Ժʱ��')
insert  controls values ('������ϸ')
insert  controls values ('����Ա')
insert  controls values ('���ѽ��')


go
create proc p_controls_select
as
select * from controls
--****************************

go
create table zhuyuanxiaofei
(
	iD int identity ,
	Kid int ,
	yaoName varchar(20),
    yaonum   int,
)


go
create  proc  p_zhuyuanxiaofei_insert
@kId			int ,			
@yaoName    varchar(20),           
@yaonum		int           
 as
       if(select COUNT(*) from zhuyuanxiaofei where Kid= @kId and yaoName=@yaoName ) >0
       begin
			  delete zhuyuanxiaofei where Kid= @kId and yaoName=@yaoName
		end 
		 insert zhuyuanxiaofei values(@kId,@yaoName, @yaonum)
--------------------------------------------------

go
create  proc  p_zhuyuanxiaofei_select
@Kid int 
as
	select * from zhuyuanxiaofei where Kid=@kId 
	-----------------------------------------------
	
	
go
create proc p_zhuyuanxiaofei_delete
@kId int ,
@yaoName varchar(20)
as
	delete zhuyuanxiaofei where Kid= @kId and yaoName=@yaoName
	
	----********************************************************************

go
create table Bingli
(
	kId					 int ,--����
	Rid					 varchar(10) , --�Һ�
	bing					varchar(20),--�������
	zhusu				varchar(50),
	xianbingshi		 varchar(50),
	jiwangbingshi	varchar(50),
	guominshi		 varchar(50),
	geirenshi			varchar(50),
	jiatingshi			varchar(50),
	tijian					varchar(50),
	fuzhu				 varchar(50),
	zhiliaojianyi		varchar(50),
)
go

create proc Bingli_insert
@kID int, @Rid varchar(10), @bing varchar(20), @zhusu varchar(50), @xianbingshi varchar(50), @jiwangbingshi varchar(50), 
@guominshi varchar(50), @geirenshi varchar(50), @jiatingshi varchar(50), @tijian varchar(50), @fuzhu varchar(50), @zhiliaojianyi varchar(50),
@result int output
as
	if(select COUNT(*) from Bingli where kId=@kId)=0
	begin
		insert Bingli values(@kID, @Rid, @bing, @zhusu, @xianbingshi, @jiwangbingshi, @guominshi, @geirenshi, @jiatingshi, @tijian,
		@fuzhu, @zhiliaojianyi)
		set @result = 1
	end
	else 
		set @result = 0


go
create table kaiyao
(
	Rid				 varchar(10),
	Kid				int ,
	yaopinName varchar(100),
	zhuangtai		 varchar(20),
	yizhu			varchar(50),
	yongfa			 varchar(100),
)


go
create table kaiyao1---Ӫҵͳ��
(
	Rid				 varchar(10),
	Kid				int ,
	yaopinName varchar(100),
	zhuangtai		 varchar(20),
	yizhu			varchar(50),
	yongfa			 varchar(100),
)

go
create proc p_kaiyaoregister_delete --��ɾ������
@Rid  varchar(10)
as 
      delete  kaiyao where  Rid = @Rid
      delete  register where Rid=@Rid 
------------------------------

go
create proc  p_kaiyao_update----�����޸Ĵ洢����
@Rid varchar(10)
as
	update kaiyao set  zhuangtai='yes' where Rid=@Rid 
update kaiyao set  zhuangtai='no' where Rid='0001' 


--UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU

go
create   proc p_kaiyao_select   ---��ѯ�Ե�ҩƷ�洢����
as
	select  register. Rid ,				--�Һű�
			  register . Doctor ,		--����ҽ��
	          register . SectionRoom ,--����
	          IdCard .  Name ,				--����
	          IdCard .  IdcardNo ,		--���֤
	          IdCard .  Sex ,				--�Ա�
	          kaiyao.   yaopinName,		--ҩƷ
	         kaiyao. zhuangtai
	 from kaiyao join   register  on kaiyao .Rid =register .Rid  join IdCard on   IdCard .KId =kaiyao.Kid 


go

create  proc kaiyao_insert   ---��Ӳ���ҩƷ
@Rid varchar(10), @Kid int, @yaopinName varchar(100), @zhuangtai varchar(20), @yizhu varchar(50), @yongfa varchar(100),
@result int output
as
	if(select COUNT(*) from kaiyao where kId=@kId)=0
	begin
		insert kaiyao values(@Rid, @kID, @yaopinName, @zhuangtai, @yizhu, @yongfa)
		insert kaiyao1 values(@Rid, @kID, @yaopinName, @zhuangtai, @yizhu, @yongfa)
		set @result = 1
	end
	else 
		set @result = 0


go
create proc p_retister_select  ---��ѯ���ύ����
as
select * from register



go
create table zhuayuantongji  --Ӫҵͳ��
(
		Kid			int ,
		Sname		 varchar(20),
		zmoney		int ,
		ymoney		int,
		 time				varchar(30),
)

go
create proc p_zhuayuantongji_select
@Kid			int ,
@Sname		varchar(20),
@zmoney	    int ,
@ymoney	    int ,
 @time			varchar(30)
as 
   insert zhuayuantongji values(@Kid, @Sname, @zmoney, @ymoney, @time)
  
  
go
 create proc  p_zhuayuantongji
  as 
      select * from zhuayuantongji
 