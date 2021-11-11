--drop  database hospitals

create database hospitals

go

use hospitals

go
--+++++++++++++++++++++++++++++++++++++++++++++++++1++++++++++++++++++++
create table IdCard                         		  --卡号表     *************
(
  KId        	int identity(10000,1)   primary key,    		 --卡号
  Name       	varchar(20),                		             --姓名
  Sex        	char(2),                    		                     --性别
  Age        	int ,					    	            	     --年龄
  Birthday   	smalldatetime,              		        --出生日期
  Address    	varchar(50),						           --地址
  Phone     	char(11),										   --电话
  Nation		varchar(20),									 --民族
  Cultrue       varchar(20),									 --文化
  Marriage      char(4),                   			 		 --婚姻状况
  Work          varchar(10),                				 --职业
  Postcode      varchar(6),                 				 --邮编  
  IdcardNo      varchar(18)             			    	--身份证号码
)
--drop table IdCard
insert IdCard values('嘻嘻','女',12,'2004-10-04','awefa','13456789023','汉','文化','未婚','无业','519000','362502199303102655')
insert IdCard values('呵呵','男',19,'2005-11-08','呵呵','13456789023','汉','文化','已婚','老师','519000','362502199303102655')
insert IdCard values('嘿嘿','女',18,'2004-12-11','哈哈','13456789023','汉','大学','未婚','金融','344410','362502199303102655')
insert IdCard values('呼呼','男',24,'2004-12-11','哈哈','13456789023','满族','高中','已婚','金融','344410','362502199303102655')
insert IdCard values('哈哈','女',20,'2004-10-04','阿根廷','13456789023','汉','中学','未婚','无业','519000','362502199303102655')
insert IdCard values('北乔峰','男',19,'2005-11-08','美国','13456789023','傣族','小学','已婚','无业','519000','362502199303102655')
insert IdCard values('欧阳','女',18,'2004-12-11','英国','13456789023','汉','大专','未婚','金融','344410','362502199303102655')
insert IdCard values('慕容','男',24,'2004-12-11','俄罗斯','13456789023','满族','硕士','已婚','心理','344410','362502199303102655')
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
create table register                                --挂号表
(
  Rid       	        varchar(10) primary key ,    --挂单号
  KId       			int ,                            --卡号
  IdType    			varchar(10),                 --号类
  GuaDanFei     		int,                         --挂单费
  OtherFei      		int,                         --其他费 
  SectionRoom   		varchar(10),                 --科室
  Doctor        		varchar(10),                 --医师
  ReristerTime  		smalldatetime,               --挂号日期
  SeeDoctorTime 		smalldatetime                --就诊日期
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
    set @mess ='挂号成功'
    end
    else
    set @mess='此卡已挂号'

    select * from register

go
 declare @mess varchar(10)
 exec p_retister_insert '0002', 10001,'普通号',10,5,'外科','张三','2012-04-09','2012-04-13',@mess output 
 select @mess

 
--+++++++++++++++++++++++++++++++++++++++++++++++3++++++++++++++++++++++
go
create table users                                   --用户表
(
  Uid				 int identity(1000,1) primary key,     		--用户编号     
  Uname        varchar(10),                 							--用户名
  name          varchar (10),     ---用户姓名
  Pwd		     varchar(10),                 						   --密码    
  Sex				 char(2),											    --性别
  Address        varchar(20),										     --地址
  Phone          char(11),												 --联系电话 
  Spell			  varchar(10),										   --拼音码
 
  Type			  varchar(20),										    --类型
   SectionRoom  varchar(10),                                      --科室
  money		  int ,													  --挂号费
  Peodom       varchar(500),									    --权限             
)


select * from users
go
insert users  values('admin','廖义德','123','男','珠海','13697777241','adimin','管理员', '',0,'-系统管理-权限管理-')
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
@Uname        varchar(10),									--用户名
@name          varchar (10),
@Pwd          varchar(10),									   --密码    
@Sex          char(2),                                              --性别
@Address      varchar(20),										 --地址
@Phone        char(11),											 --联系电话
@Spell        varchar(10),										--拼音码
@Type         varchar(20),								     --类型
@SectionRoom varchar(10),
@money      int,                              					 --挂号费	
@Peodom       varchar(500),								 --权限   
@result       varchar(20) output								   
as
    if (select COUNT(*) from users where Uname=@Uname)=0
        begin 
          insert users values(@Uname,@name,@Pwd,@Sex,@Address,@Phone, @Spell, @Type,@SectionRoom,@money,@Peodom)
           set @result = '添加成功'
         end
         else
           set @result = '用户名已经存在'

 select * from users   

--****************************************************************************************************** 


go
create table usersType   --类型表
(
	Tid  int  identity(1,1) primary key,
    Type         varchar(20), 
    Peodom       varchar(500)   
)
insert  usersType values('管理员','系统管理-权限设置' )

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
		 set @mess='添加成功！'
 end
  else 
    set @mess='此类型以存在！'
   
    
   


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
create table nurse                                	--护士表
(
    Nid int identity (1,1) primary key,           	--护士编号
    Name varchar(10),                             	--护士名
    Type varchar(10)                              	--类型
    
)


--++++++++++++++++++++++++++++++++++++++++++++++++4+++++++++++++++++++++

go

create  table  SectionRoom                 			--科室表
(
   Sid           int   identity(1,1)    primary key,                     --编号
   Sname          varchar(10) ,                      	--科室名
   Saddr          varchar(20) ,                      --科室地址
   Sprice         int                               --挂号费 
)
go
insert SectionRoom values('外科' ,'2楼外科室',5)
insert SectionRoom values('内科','3楼内科室',6)
insert SectionRoom values('骨伤科','4楼骨伤科室',10)
insert SectionRoom values('眼科','2楼眼科室',15)
insert SectionRoom values('儿科','5楼儿科室',25)
insert SectionRoom values('精神科','2楼精神科室',15)
insert SectionRoom values('皮肤科','3楼皮肤科室',25)
insert SectionRoom values('肿瘤科','1楼肿瘤科室',10)
insert SectionRoom values('结核科','5楼结核科室',5)
insert SectionRoom values('传染科','3楼传染科室',25)
insert SectionRoom values('神经科','2楼神经科室',30)
insert SectionRoom values('老年科','3楼老年科室',20)
insert SectionRoom values('产科','4楼产科室',10)
insert SectionRoom values('中医科','2楼中医科室',50)
insert SectionRoom values('耳鼻咽喉科','1楼耳鼻咽喉科室',15)
insert SectionRoom values('口腔科','2楼口腔科室',25)
insert SectionRoom values('妇科','3楼妇科室',35)
insert SectionRoom values('肾移植','2楼肾移植室',25)

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
       set @result='此科室已有'
      
     
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
create table SectionRooomSon               			--子科室表
(
   SonId         int identity(1,1) primary key,
   Sname         varchar(10),                     	--科室名
   SonName       varchar(10)                    	--子科室名
) 

go
create  proc p_SectionRooomSonDelete
@SonName	     varchar(10) ,
@result   varchar(20)  output
as
			delete SectionRooomSon where  SonName=@SonName
			set @result='删除成功'


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
        set @result='此子科室已经添加'
   
  go 
  declare @result  varchar(20)
  exec p_SectionRooomSonInsert '外科','呵呵',@result output
  select @result






--++++++++++++++++++++++++++++++++++++++++++++++++6+++++++++++++++++++++
--select * from Drug_insert

go
create table  Drug_insert    						--药品入库表
(
   Dname           varchar(10),    				    --药品名称
   Dtype             varchar(10),    				    --药品类型
   DcostName     varchar(10),    			        --费用名称
   Dspec              varchar(10),                       --规格  
   DjiXing            varchar(10),                       --剂型   
   DinsertPrice      int,            			                 --进价
   DsellPrice         int,             			                --售价
   Dstock              int,            			              --库存
   DstockMax        int,							          --库存上限
   DstockMin         int,           			             --库存下限
   DeffectTime     smalldatetime,                     --有效期
   DproductTime  smalldatetime,                     --生产期
   Efficay              varchar(50)                          --病功效
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
create table sickroom  --病房表
(
    Idsickroom  int  primary key,         --病房号
    Sid				int,                             --科别
    Tyep				 varchar(10),                              --病房类型 
    Price					 int                             --价格
)



select * from sickroom  

go
 create  proc p_sickroom_insert --添加病房
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
			  set @result='@Idsickroom   房号一出现相同'
	
	
go		  
create proc p_sickroom_select  --查询病房
as
	select * from sickroom
	
go
create proc p_sickroom_Delete
@Idsickroom int 
as
	delete sickroom where @Idsickroom=Idsickroom

 --++++++++++++++++++++++++++++++++++++++++++++++++9床位表+++++++++++++++++++++
go


create table   bed    --床位表
(
      Idsickroom   int,				 --病房好
	  Idbed           int,				 --床位号
	  KId               int,			     --病人卡号
	 State              varchar(10),      --床位状态
)
select * from bed

go
create proc p_bed_update
@Idsickroom int ,
@Idbed int 
as
	update bed set State='空' where @Idsickroom=Idsickroom and @Idbed=Idbed


go
 create proc p_bed_insert --添加病床
@Idsickroom int ,
@Idbed int,
@KId   int,
@State varchar(10)
as
   insert bed values(@Idsickroom, @Idbed,@KId,@State)


go
create proc p_bed_select--查询病房
as 
   select * from bed
  
  
 go 
create proc p_bed_Delete --删除病房
@Idsickroom int 
as
	delete bed where @Idsickroom=Idsickroom

--drop table bed

 --++++++++++++++++++++++++++++++++++++++++++++++++10病人住院表+++++++++++++++++++++
go

create table zhuyuan  --病人住院表
(
	kId				int ,				 --病人卡号
	Sid               int,                 --科室
	Idsickroom   int ,               --病房号
    BedNo			varchar(10),	 --床位
    Imprest			int,				 --预交费
	Bewrite			varchar(50),	 --病情描述
    Tabu				varchar(50),	 --药物禁忌
    Ztime              datetime   --登记时间
)

go
create proc   p_zhuyuanzhuyuanxiaofei_deleted ----住院买单删除数据
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
create  proc p_zhuyuan_insert  --住院查询
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
				update  bed set  State='占用' where @Idsickroom=Idsickroom and @BedNo=Idbed
 				 set @result ='OK'
		   end 
    end
   else
             set   @result ='NO'
   
     

 --++++++++++++++++++++++++++++++++++++++++++++++++11住院病人病历表+++++++++++++++++++++
go

create table casehistory   --住院病人病历表
(
	  UId					varchar(10),				--工作人员编号
	  BedNo			varchar(10),				--床位
	  UseDrug         varchar(50),				--使用药品
	  Disposal          varchar(50),				--病情处理
      Time               smalldatetime,			--检查时间
      Remark           varchar(50),              --检查备注    
)

-----*****************************
go
create table   controlinfo  ---   消费单
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
create table controls	 --打印项目
(
	name varchar(20),
)
insert  controls values ('标题')
insert  controls values ('编号')
insert  controls values ('病房号')
insert  controls values ('入院时间')
insert  controls values ('出院时间')
insert  controls values ('消费明细')
insert  controls values ('收银员')
insert  controls values ('消费金额')


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
	kId					 int ,--卡号
	Rid					 varchar(10) , --挂号
	bing					varchar(20),--初步诊断
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
create table kaiyao1---营业统计
(
	Rid				 varchar(10),
	Kid				int ,
	yaopinName varchar(100),
	zhuangtai		 varchar(20),
	yizhu			varchar(50),
	yongfa			 varchar(100),
)

go
create proc p_kaiyaoregister_delete --买单删除数据
@Rid  varchar(10)
as 
      delete  kaiyao where  Rid = @Rid
      delete  register where Rid=@Rid 
------------------------------

go
create proc  p_kaiyao_update----以买单修改存储过程
@Rid varchar(10)
as
	update kaiyao set  zhuangtai='yes' where Rid=@Rid 
update kaiyao set  zhuangtai='no' where Rid='0001' 


--UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU

go
create   proc p_kaiyao_select   ---查询以点药品存储过程
as
	select  register. Rid ,				--挂号表
			  register . Doctor ,		--主诊医生
	          register . SectionRoom ,--科室
	          IdCard .  Name ,				--姓名
	          IdCard .  IdcardNo ,		--身份证
	          IdCard .  Sex ,				--性别
	          kaiyao.   yaopinName,		--药品
	         kaiyao. zhuangtai
	 from kaiyao join   register  on kaiyao .Rid =register .Rid  join IdCard on   IdCard .KId =kaiyao.Kid 


go

create  proc kaiyao_insert   ---添加病人药品
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
create proc p_retister_select  ---查询已提交病人
as
select * from register



go
create table zhuayuantongji  --营业统计
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
 