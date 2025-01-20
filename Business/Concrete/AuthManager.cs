﻿using Business.Abstract;
using Business.BusinessRules.Auth;
using Business.Dtos.Auth.Login;
using Business.Dtos.Auth.Register;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using DataAccess.Repositories.Abstract;

namespace Business.Concrete
{
    
    public class AuthManager : IAuthService
    {
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IUserReadRepository _userReadRepository;
        private readonly AuthBusinessRules _authBusinessRules;

        public AuthManager(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository, AuthBusinessRules authBusinessRules)
        {
            _userWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
            _authBusinessRules = authBusinessRules;
        }

        public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            await _authBusinessRules.UserExistsAsync(loginRequestDto.Email);


        }

        public async Task<RegisterResponseDto> Register(RegisterRequestDto registerRequestDto)
        {
            await _authBusinessRules.UserExistsAsync(registerRequestDto.Email);

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(registerRequestDto.Password, out passwordHash, out passwordSalt);

            var user = new User()
            {
                FirstName = registerRequestDto.FirstName,
                LastName = registerRequestDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Email = registerRequestDto.Email,
                CreatedDate = DateTime.UtcNow,
            };

            
            await _userWriteRepository.AddAsync(user);

            var registerResponseDto = new RegisterResponseDto()
            {
                Email = registerRequestDto.Email,
                Succeeded = true
            };

            return registerResponseDto;
        }

    }
}

