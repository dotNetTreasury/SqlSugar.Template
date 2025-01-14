﻿using DMSN.Common.BaseResult;
using SqlSugar.Template.Contracts.Param;
using SqlSugar.Template.Contracts.Result;
using SqlSugar.Template.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SqlSugar.Template.Contracts
{
    /// <summary>
    /// 日志接口定义
    /// </summary>
    public interface ISysJobLogService
    {
        Task<ResponseResult> Add2Async(AddJobLogParam param);
        /// <summary>
        /// 异步新增
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<ResponseResult> AddAsync(AddJobLogParam param);
        /// <summary>
        /// 事物处理
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<ResponseResult> AddTranAsync(AddJobLogParam param);
        /// <summary>
        /// 异步修改
        /// </summary>
        /// <returns></returns>
        Task<ResponseResult> UpdateAsync(long jobLogID);
        /// <summary>
        /// 异步删除
        /// </summary>
        /// <returns></returns>
        Task<ResponseResult> DeleteAsync(long jobLogID);
        /// <summary>
        /// 异步查询
        /// </summary>
        /// <returns></returns>
        Task<ResponseResult<JobLogResult>> GetJobLogAsync(long jobLogID);
        /// <summary>
        /// 异步查询
        /// </summary>
        /// <returns></returns>
        Task<ResponseResult<List<JobLogResult>>> GetJobLogListAsync(long jobLogType);
        /// <summary>
        /// 异步查询
        /// </summary>
        /// <returns></returns>
        Task<ResponsePageResult<JobLogResult>> SearchJobLogAsync(SearchJobLogParam param);



        //Task<ResponseResultV2> GetJobLogV1Async(long jobLogID);
        //Task<ResponseResultV2<JobLogResult>> GetJobLogV2Async(long jobLogID);
        //Task<ResponseResultV2<PageModel<JobLogResult>>> SearchJobLogV2Async(SearchJobLogParam param);
    }
}
