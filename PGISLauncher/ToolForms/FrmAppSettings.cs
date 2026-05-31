using PGISLauncher.API.Service;
using PGISLauncher.Base;
using PGISLauncher.Domain.Entities;
using PGISLauncher.Interfaces;
using System;
using System.Threading.Tasks;

namespace PGISLauncher.ToolForms
{
    public partial class FrmAppSettings : BaseForm
    {
        private IControlMapper<InformationSystem> _controlMapper;
        private readonly ICryptography _cryptography;
        private readonly IInfoSystemService _infoSystemService;

        private InformationSystem _informationSystem;
        private readonly FileService _fileService;
        public FrmAppSettings(IControlMapper<InformationSystem> controlMapper, ICryptography cryptography,
            IInfoSystemService infoSystemService, FileService fileService)
        {
            _controlMapper = controlMapper;
            _cryptography = cryptography;
            _fileService = fileService;
            _infoSystemService = infoSystemService;
            InitializeComponent();
        }

        public void InitForm(InformationSystem informationSystem = null)
        {
            _informationSystem = informationSystem;
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
            var infoSystem = new InformationSystem();
            await MapAndSave(infoSystem);
        }

        private async Task UpdateAppSettings()
        {
            var infoSystem = await _infoSystemService.GetByIdAsync(_informationSystem.Id);
            await MapAndSave(infoSystem);
        }

        private async Task MapAndSave(InformationSystem infoSystem)
        {
            _controlMapper.MapToEntity(infoSystem, this);

            var securityStamp = Guid.NewGuid().ToString();
            var fileName = $"{_cryptography.Encrypt(infoSystem.AcrName, securityStamp)}.jpeg";

            infoSystem.IconPath = fileName;
            infoSystem.IconPathSecurityStamp = securityStamp;
            await SaveImage(fileName);

            if (_informationSystem == null) await _infoSystemService.AddAsync(infoSystem);
            await _infoSystemService.SaveChangesAsync();
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