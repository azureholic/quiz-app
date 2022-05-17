module.exports = async function (context, req) {
    context.res.json({
        apiurl: process.env.API_URI
    });
}