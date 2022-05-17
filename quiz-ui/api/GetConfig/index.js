module.exports = async function (context, req) {
    context.res.json({
        apiuri: process.env.API_URI
    });
}