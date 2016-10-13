namespace EformAPI2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EformDb : DbContext
    {
        public EformDb()
            : base("name=eform")
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<Creditors> Creditors { get; set; }
        public virtual DbSet<CRoles> CRoles { get; set; }
        public virtual DbSet<CUsers> CUsers { get; set; }
        public virtual DbSet<department> department { get; set; }
        public virtual DbSet<EFlowMain> EFlowMain { get; set; }
        public virtual DbSet<FlowInstances> FlowInstances { get; set; }
        public virtual DbSet<userClaim> userClaim { get; set; }
        public virtual DbSet<EAdvanceFunction> EAdvanceFunction { get; set; }
        public virtual DbSet<ECompany> ECompany { get; set; }
        public virtual DbSet<EConstant> EConstant { get; set; }
        public virtual DbSet<EDep> EDep { get; set; }
        public virtual DbSet<EFlowSub> EFlowSub { get; set; }
        public virtual DbSet<EForm_useflag0v> EForm_useflag0v { get; set; }
        public virtual DbSet<EFormAttachFile> EFormAttachFile { get; set; }
        public virtual DbSet<EFormBasic> EFormBasic { get; set; }
        public virtual DbSet<EFormData> EFormData { get; set; }
        public virtual DbSet<EFormDataBK> EFormDataBK { get; set; }
        public virtual DbSet<EFormGroup> EFormGroup { get; set; }
        public virtual DbSet<EFormPermit> EFormPermit { get; set; }
        public virtual DbSet<EFormStatusCC> EFormStatusCC { get; set; }
        public virtual DbSet<EFormStatusMain> EFormStatusMain { get; set; }
        public virtual DbSet<EFormStatusSub> EFormStatusSub { get; set; }
        public virtual DbSet<EFormStatusView> EFormStatusView { get; set; }
        public virtual DbSet<EFormTag> EFormTag { get; set; }
        public virtual DbSet<EFormUserFlow> EFormUserFlow { get; set; }
        public virtual DbSet<EHistoryQueryList> EHistoryQueryList { get; set; }
        public virtual DbSet<ELoginRecord> ELoginRecord { get; set; }
        public virtual DbSet<ELoginTotal> ELoginTotal { get; set; }
        public virtual DbSet<EReplace> EReplace { get; set; }
        public virtual DbSet<ESystemMsg> ESystemMsg { get; set; }
        public virtual DbSet<ETask> ETask { get; set; }
        public virtual DbSet<ETitleClass> ETitleClass { get; set; }
        public virtual DbSet<EUser> EUser { get; set; }
        public virtual DbSet<EUserGroup> EUserGroup { get; set; }
        public virtual DbSet<EUserGroupSub> EUserGroupSub { get; set; }
        public virtual DbSet<MainBtnGroup> MainBtnGroup { get; set; }
        public virtual DbSet<MainBtnItem> MainBtnItem { get; set; }
        public virtual DbSet<MainBtnSet> MainBtnSet { get; set; }
        public virtual DbSet<MainBtnUser> MainBtnUser { get; set; }
        public virtual DbSet<MainTreeDep> MainTreeDep { get; set; }
        public virtual DbSet<MainTreeExe> MainTreeExe { get; set; }
        public virtual DbSet<MainTreeItem> MainTreeItem { get; set; }
        public virtual DbSet<MainTreeItemPermit> MainTreeItemPermit { get; set; }
        public virtual DbSet<MainTreeNode> MainTreeNode { get; set; }
        public virtual DbSet<MainTreeNodePermit> MainTreeNodePermit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.userClaim)
                .WithRequired(e => e.Account)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.Account)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.Account)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<EFlowMain>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFlowMain>()
                .Property(e => e.flow_name)
                .IsUnicode(false);

            modelBuilder.Entity<EFlowMain>()
                .Property(e => e.flow_share_nmae)
                .IsUnicode(false);

            modelBuilder.Entity<EFlowMain>()
                .Property(e => e.designer)
                .IsUnicode(false);

            modelBuilder.Entity<EFlowMain>()
                .Property(e => e.modifier)
                .IsUnicode(false);

            modelBuilder.Entity<EFlowMain>()
                .Property(e => e.flow_version)
                .IsUnicode(false);

            modelBuilder.Entity<EFlowMain>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<EAdvanceFunction>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EAdvanceFunction>()
                .Property(e => e.version_no)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.co_name)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.co_name_abbr)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.co_invoice_no)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.boss)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.contact)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.capital)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.co_invoice_addr)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.tax_office)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.declare_code)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.tax_code)
                .IsUnicode(false);

            modelBuilder.Entity<ECompany>()
                .Property(e => e.house_code)
                .IsUnicode(false);

            modelBuilder.Entity<EConstant>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EConstant>()
                .Property(e => e.constant_name)
                .IsUnicode(false);

            modelBuilder.Entity<EConstant>()
                .Property(e => e.constant_value)
                .IsUnicode(false);

            modelBuilder.Entity<EDep>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EDep>()
                .Property(e => e.dep_id)
                .IsUnicode(false);

            modelBuilder.Entity<EDep>()
                .Property(e => e.dep_name)
                .IsUnicode(false);

            modelBuilder.Entity<EDep>()
                .Property(e => e.dep_manager)
                .IsUnicode(false);

            modelBuilder.Entity<EDep>()
                .Property(e => e.dep_pid)
                .IsUnicode(false);

            modelBuilder.Entity<EDep>()
                .Property(e => e.dep_remark)
                .IsUnicode(false);

            modelBuilder.Entity<EFlowSub>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFlowSub>()
                .Property(e => e.node_name)
                .IsUnicode(false);

            modelBuilder.Entity<EForm_useflag0v>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormAttachFile>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormAttachFile>()
                .Property(e => e.login_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormAttachFile>()
                .Property(e => e.time_stamp)
                .IsUnicode(false);

            modelBuilder.Entity<EFormAttachFile>()
                .Property(e => e.file_path)
                .IsUnicode(false);

            modelBuilder.Entity<EFormAttachFile>()
                .Property(e => e.file_name)
                .IsUnicode(false);

            modelBuilder.Entity<EFormAttachFile>()
                .Property(e => e.attach_user)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.form_name)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.apply_path)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.apply_file)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.check_path)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.check_file)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.notify_path)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.notify_file)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.programmer)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.form_version)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.help_file)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.print_file)
                .IsUnicode(false);

            modelBuilder.Entity<EFormBasic>()
                .Property(e => e.read_file)
                .IsUnicode(false);

            modelBuilder.Entity<EFormData>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormData>()
                .Property(e => e.ctl_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormData>()
                .Property(e => e.ctl_index)
                .IsUnicode(false);

            modelBuilder.Entity<EFormData>()
                .Property(e => e.ctl_value)
                .IsUnicode(false);

            modelBuilder.Entity<EFormDataBK>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormDataBK>()
                .Property(e => e.usr_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormDataBK>()
                .Property(e => e.ctl_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormDataBK>()
                .Property(e => e.ctl_index)
                .IsUnicode(false);

            modelBuilder.Entity<EFormDataBK>()
                .Property(e => e.ctl_value)
                .IsUnicode(false);

            modelBuilder.Entity<EFormDataBK>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<EFormGroup>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormGroup>()
                .Property(e => e.node_name)
                .IsUnicode(false);

            modelBuilder.Entity<EFormPermit>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormPermit>()
                .Property(e => e.ugroup_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusCC>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusCC>()
                .Property(e => e.login_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusCC>()
                .Property(e => e.time_stamp)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusCC>()
                .Property(e => e.usr_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusMain>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusMain>()
                .Property(e => e.apply_title)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusMain>()
                .Property(e => e.usr_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusSub>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusSub>()
                .Property(e => e.logic_data)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusSub>()
                .Property(e => e.check_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusSub>()
                .Property(e => e.check_remark)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusSub>()
                .Property(e => e.default_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusSub>()
                .Property(e => e.item_remark)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusView>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusView>()
                .Property(e => e.login_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusView>()
                .Property(e => e.time_stamp)
                .IsUnicode(false);

            modelBuilder.Entity<EFormStatusView>()
                .Property(e => e.usr_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormTag>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormTag>()
                .Property(e => e.ctl_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormTag>()
                .Property(e => e.ctl_index)
                .IsUnicode(false);

            modelBuilder.Entity<EFormTag>()
                .Property(e => e.ctl_type)
                .IsUnicode(false);

            modelBuilder.Entity<EFormTag>()
                .Property(e => e.ctl_temp)
                .IsUnicode(false);

            modelBuilder.Entity<EFormTag>()
                .Property(e => e.ctl_remark)
                .IsUnicode(false);

            modelBuilder.Entity<EFormTag>()
                .Property(e => e.ValidMethod)
                .IsUnicode(false);

            modelBuilder.Entity<EFormUserFlow>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EFormUserFlow>()
                .Property(e => e.login_id)
                .IsUnicode(false);

            modelBuilder.Entity<EFormUserFlow>()
                .Property(e => e.time_stamp)
                .IsUnicode(false);

            modelBuilder.Entity<EFormUserFlow>()
                .Property(e => e.usr_id)
                .IsUnicode(false);

            modelBuilder.Entity<EHistoryQueryList>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EHistoryQueryList>()
                .Property(e => e.ugroup_id)
                .IsUnicode(false);

            modelBuilder.Entity<EHistoryQueryList>()
                .Property(e => e.form_power)
                .IsUnicode(false);

            modelBuilder.Entity<ELoginRecord>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<ELoginRecord>()
                .Property(e => e.login_id)
                .IsUnicode(false);

            modelBuilder.Entity<ELoginRecord>()
                .Property(e => e.ip_last)
                .IsUnicode(false);

            modelBuilder.Entity<ELoginTotal>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EReplace>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EReplace>()
                .Property(e => e.usr_id)
                .IsUnicode(false);

            modelBuilder.Entity<EReplace>()
                .Property(e => e.replace_id)
                .IsUnicode(false);

            modelBuilder.Entity<EReplace>()
                .Property(e => e.usr_reason)
                .IsUnicode(false);

            modelBuilder.Entity<EReplace>()
                .Property(e => e.stop_user)
                .IsUnicode(false);

            modelBuilder.Entity<ESystemMsg>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<ESystemMsg>()
                .Property(e => e.send_user)
                .IsUnicode(false);

            modelBuilder.Entity<ESystemMsg>()
                .Property(e => e.msg_title)
                .IsUnicode(false);

            modelBuilder.Entity<ESystemMsg>()
                .Property(e => e.msg_body)
                .IsUnicode(false);

            modelBuilder.Entity<ESystemMsg>()
                .Property(e => e.msg_user)
                .IsUnicode(false);

            modelBuilder.Entity<ETask>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<ETask>()
                .Property(e => e.task_name)
                .IsUnicode(false);

            modelBuilder.Entity<ETask>()
                .Property(e => e.task_user)
                .IsUnicode(false);

            modelBuilder.Entity<ETask>()
                .Property(e => e.task_owner)
                .IsUnicode(false);

            modelBuilder.Entity<ETitleClass>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<ETitleClass>()
                .Property(e => e.class_name)
                .IsUnicode(false);

            modelBuilder.Entity<ETitleClass>()
                .Property(e => e.class_remark)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_id)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_email)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_tel)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_subtel)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_celltel)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_pwd)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.dep_id)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_replace)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_remark)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_title)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_reason)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.usr_replace1)
                .IsUnicode(false);

            modelBuilder.Entity<EUser>()
                .Property(e => e.pwd2)
                .IsUnicode(false);

            modelBuilder.Entity<EUserGroup>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EUserGroup>()
                .Property(e => e.ugroup_id)
                .IsUnicode(false);

            modelBuilder.Entity<EUserGroup>()
                .Property(e => e.ugroup_name)
                .IsUnicode(false);

            modelBuilder.Entity<EUserGroup>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<EUserGroupSub>()
                .Property(e => e.co_code)
                .IsUnicode(false);

            modelBuilder.Entity<EUserGroupSub>()
                .Property(e => e.ugroup_id)
                .IsUnicode(false);

            modelBuilder.Entity<EUserGroupSub>()
                .Property(e => e.dep_uid)
                .IsUnicode(false);

            modelBuilder.Entity<MainBtnGroup>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<MainBtnGroup>()
                .Property(e => e.group_remark)
                .IsUnicode(false);

            modelBuilder.Entity<MainBtnItem>()
                .Property(e => e.parent_caption)
                .IsUnicode(false);

            modelBuilder.Entity<MainBtnItem>()
                .Property(e => e.child_caption)
                .IsUnicode(false);

            modelBuilder.Entity<MainBtnSet>()
                .Property(e => e.parent_caption)
                .IsUnicode(false);

            modelBuilder.Entity<MainBtnSet>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<MainBtnUser>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<MainBtnUser>()
                .Property(e => e.usr_id)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeDep>()
                .Property(e => e.dep_id)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeDep>()
                .Property(e => e.dep_name)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeDep>()
                .Property(e => e.dep_manager)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeDep>()
                .Property(e => e.dep_pid)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeDep>()
                .Property(e => e.dep_remark)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeExe>()
                .Property(e => e.node_exe_root)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeExe>()
                .Property(e => e.node_exe_name)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeExe>()
                .Property(e => e.node_exe_path)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeExe>()
                .Property(e => e.node_exe_title)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeExe>()
                .Property(e => e.node_exe_source)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeExe>()
                .Property(e => e.node_exe_version)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeExe>()
                .Property(e => e.node_process_title)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeItem>()
                .Property(e => e.parent_caption)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeItem>()
                .Property(e => e.child_caption)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeItem>()
                .Property(e => e.root_caption)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeItemPermit>()
                .Property(e => e.parent_caption)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeItemPermit>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNode>()
                .Property(e => e.node_name)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNode>()
                .Property(e => e.node_remark)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNode>()
                .Property(e => e.node_exe)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNode>()
                .Property(e => e.node_exe_path)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNode>()
                .Property(e => e.node_exe_title)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNode>()
                .Property(e => e.node_exe_root)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNode>()
                .Property(e => e.node_help_path)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNode>()
                .Property(e => e.node_help_name)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNode>()
                .Property(e => e.node_web_path)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNode>()
                .Property(e => e.node_web_file)
                .IsUnicode(false);

            modelBuilder.Entity<MainTreeNodePermit>()
                .Property(e => e.group_name)
                .IsUnicode(false);
        }
    }
}
