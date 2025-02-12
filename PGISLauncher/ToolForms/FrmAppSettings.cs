using Helpers.Interface;
using Helpers.Security;
using Helpers.Service;
using Helpers.Utility;
using Model.Entities;
using Model.Interface;
using Model.Repository;
using PGISLauncher.Base;
using System;
using System.Threading.Tasks;

namespace PGISLauncher.ToolForms
{
    public partial class FrmAppSettings : BaseForm
    {
        private readonly InformationSystem _informationSystem;
        private readonly FileService _fileService;
        private IControlMapper<InformationSystem> _controlMapper;
        private readonly ICryptography _cryptography;
        public FrmAppSettings(InformationSystem informationSystem)
        {
            InitializeComponent();
            _informationSystem = informationSystem;
            _fileService = new FileService();
            _controlMapper = new ControlMapper<InformationSystem>();
            _cryptography = new Cryptography();
            _fileService = new FileService();
        }

        public FrmAppSettings()
        {
            InitializeComponent();
            _fileService = new FileService();
            _controlMapper = new ControlMapper<InformationSystem>();
            _cryptography = new Cryptography();
            _fileService = new FileService();
        }

        private async Task LoadDetails()
        {
            if (_informationSystem == null) return;
            _controlMapper.MapToControls(_informationSystem, this);
            picAppImage.Image = await _fileService.DownloadFile(_informationSystem.IconPath);
        }

        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            if (_informationSystem == null) await SaveNewApp();
            else await UpdateAppSettings();
        }

        private async Task SaveNewApp()
        {
            var unitOfWork = new UnitOfWork();
            var infoSystem = new InformationSystem();
            await MapAndSave(infoSystem, unitOfWork);
        }

        private async Task UpdateAppSettings()
        {
            var unitOfWork = new UnitOfWork();
            var infoSystem = await unitOfWork.InformationSystemRepo.FindAsync(x => x.Id == _informationSystem.Id);
            await MapAndSave(infoSystem, unitOfWork);
        }

        private async Task MapAndSave(InformationSystem infoSystem, IUnitOfWork unitOfWork)
        {
            _controlMapper.MapToEntity(infoSystem, this);

            var securityStamp = Guid.NewGuid().ToString();
            var fileName = $"{_cryptography.Encrypt(infoSystem.AcrName, securityStamp)}.jpeg";

            infoSystem.IconPath = fileName;
            infoSystem.IconPathSecurityStamp = securityStamp;
            await SaveImage(fileName);

            if (_informationSystem == null) unitOfWork.InformationSystemRepo.Insert(infoSystem);
            await unitOfWork.SaveAsync();
            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private async Task SaveImage(string fileName)
        {
            await _fileService.UploadFile(picAppImage.Image, fileName);
        }

        private async void FrmAppSettings_Load(object sender, EventArgs e)
        {
            await LoadDetails();
        }
    }
}